using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using QuanLyTour.Biz;

namespace QuanLyTour.Dal
{
    public class TourDAL
    {
        private SqlConnection con = new SqlConnection();
        public TourDAL()
        {
            con.ConnectionString=@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTour;Integrated Security=True";
        }
        private Boolean qOpen()
        {
            try
            {
                this.con.Open();
                Debug.WriteLine("Mo ket noi thanh cong");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Khong the mo ket noi");
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        private Boolean qClose()
        {
            try
            {
                this.con.Close();
                Debug.WriteLine("Dong ket noi thanh cong");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Khong the dong ket noi");
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        public List<TourBiz> getAll()
        {
            string sql = "select * from Tour order by id_tour";
            Boolean ok=this.qOpen();
            if (ok == false) return null;
            try
            {
                Debug.WriteLine("GetAll Tour_"+sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) return new List<TourBiz>();
                Debug.WriteLine("có kquả");
                List<TourBiz> list = new List<TourBiz>();
                    while (reader.Read())
                    {
                        TourBiz dt = new TourBiz();
                        dt.matour = reader[1].ToString();
                        dt.tentour = reader[2].ToString();
                        dt.tourtn = (reader[3].Equals(true)) ? 1 : 0;
                  //      Debug.WriteLine(dt.matour+"_"+dt.tentour);
                        list.Add(dt);
                    }
                this.qClose();
                return list;
            }
            catch
            {
                this.qClose();
                Debug.WriteLine("Tour getAll() failed!");
                return new List<TourBiz>();
            }
        }
        public Boolean check_ma(String ma)
        {
            string sql = "select * from Tour where matour=N'" + ma + "'";
            Debug.WriteLine("Kiểm tra mã_" + sql);
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            SqlCommand cmd = new SqlCommand(sql, this.con);
            SqlDataReader reader = cmd.ExecuteReader();
            Boolean rs = reader.HasRows;
            this.qClose();
//  Debug.WriteLine("Số dòng:" + rs);
            if (rs) return false;
            return true;
        }
        public Boolean Insert(TourBiz dt)
        {
            string sql = "insert into Tour (matour,tentour,tourtn) values(N'"+dt.matour+"',N'"+dt.tentour+"',"+dt.tourtn.ToString()+")";
             Boolean ok=this.qOpen();
             if (ok == false) return false;
            try
            {
                Debug.WriteLine("Insert Tour_"+sql);
                SqlCommand cmd = new SqlCommand(sql,this.con);
                int rs=cmd.ExecuteNonQuery();
                Boolean rs2 = true;
                this.qClose();
                //thêm giá tour
                foreach (GiaTourBiz gt in dt.ds_giatour)
                {
                    rs2 = rs2 & gt.them();
                }
                //thêm địa điểm
                DanhSachDDDAL dal = new DanhSachDDDAL();
                Boolean rs3 = dal.Insert(dt);
                if (rs2==false || rs == 0 || rs3==false) return false;
                return true;
               
            }
            catch
            {
                Debug.WriteLine("Tour insert failed!");
                return false;
            }
        }
        public Boolean Edit(TourBiz dt)
        {
            string sql = "update Tour set tentour=N'"+dt.tentour + "',tourtn="+dt.tourtn+" where matour=N'"+dt.matour+"'";
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            try
            {
                Debug.WriteLine("edit Tour_" + sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                int rs = cmd.ExecuteNonQuery();
                this.qClose();
                //sửa ds giá tour
                Boolean rs2 = true;
                foreach (GiaTourBiz gt in dt.ds_giatour)
                {
                   //thêm giá tour mới cho tour hoặc sửa thông tin gía tour cũ
                    if (gt.ktra_ma()) rs2 = rs2 & gt.them();
                    else if (!gt.ktra_ma()) rs2 = rs2 & gt.sua();
                }
                //Xóa giá tour trong tour
                GiaTourDAL gtdal = new GiaTourDAL();
                List<GiaTourBiz> list = new List<GiaTourBiz>();
                list = gtdal.getAll(dt.matour);
                if (list.Count > dt.ds_giatour.Count)
                {
                    foreach (GiaTourBiz gt_du in list)
                    {
                        int count = 0;
                        foreach (GiaTourBiz gt in dt.ds_giatour)
                        {
                            if (gt_du.magia == gt.magia) count++;
                        }
                        if (count == 0) gt_du.xoa();
                    }
                }
                //sửa ds địa điểm
                DanhSachDDDAL dsdal = new DanhSachDDDAL();
                Boolean rs3=dsdal.Edit(dt);
                if (rs2 == false || rs == 0 || rs3==false) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("Tour Edit failed!");
                return false;
            }
        }
        public Boolean delete(TourBiz dt)
        {
            string sql = "delete from Tour where matour=N'" + dt.matour + "'";
            Boolean rs2 = true;
            // xóa giá tour
            foreach (GiaTourBiz gt in dt.ds_giatour)
            {
                rs2 = rs2 & gt.xoa();
            }
            //xóa địa điểm
            DanhSachDDDAL dal = new DanhSachDDDAL();
            dal.delete(dt);
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            try
            {
                Debug.WriteLine("delete Tour_" + sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                int rs = cmd.ExecuteNonQuery();
                this.qClose();
               
                if (rs == 0 || rs2==false) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("Tour delete failed!");
                return false;
            }
        }
    }
}
