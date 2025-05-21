using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTour.Biz;

namespace QuanLyTour.Dal
{
    public class GiaTourDAL
    {
         private SqlConnection con = new SqlConnection();
        public GiaTourDAL()
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
        public List<GiaTourBiz> getAll(String matour)
        {
            string sql = "select * from GiaTour where matour='"+matour+"' order by id_gia asc";
            Boolean ok=this.qOpen();
            if (ok == false) return null;
            try
            {
                Debug.WriteLine("GetAll GiaTour_"+sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) return new List<GiaTourBiz>();
                List<GiaTourBiz> list = new List<GiaTourBiz>();
                    while (reader.Read())
                    {
                        GiaTourBiz dt = new GiaTourBiz();
                        dt.magia= reader[1].ToString();
                        dt.giatri = long.Parse(reader[2].ToString());
                        dt.thoigianbatdau = DateTime.Parse(reader[3].ToString());
                        dt.thoigianketthuc = DateTime.Parse(reader[4].ToString());
                        dt.dangapdung = (reader[5].Equals(true)) ? 1 : 0;
                  //      Debug.WriteLine(dt.matour+"_"+dt.tentour);
                        list.Add(dt);
                    }
                this.qClose();
                return list;
            }
            catch
            {
                Debug.WriteLine("Tour getAll() failed!");
                return new List<GiaTourBiz>();
            }
        }
        public Boolean check_ma(String ma)
        {
            string sql = "select * from GiaTour where magia=N'" + ma + "'";
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
        public Boolean Insert(GiaTourBiz dt)
        {
            string sql = "insert into GiaTour (magia,giatri,thoigianbatdau,thoigianketthuc,dangapdung,matour) values(N'"+dt.magia+"',"+dt.giatri+",convert(date,'"+dt.thoigianbatdau.Date.ToShortDateString()+"',103),convert(date,'"+dt.thoigianketthuc.Date.ToShortDateString()+"',103),"+dt.dangapdung+",N'"+dt.matour+"')";
             Boolean ok=this.qOpen();
             if (ok == false) return false;
            try
            {
                Debug.WriteLine("Insert GiaTour_"+sql);
                SqlCommand cmd = new SqlCommand(sql,this.con);
                int rs=cmd.ExecuteNonQuery();
                this.qClose();
                if (rs == 0) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("GiaTour insert failed!");
                return false;
            }
        }
        public Boolean Edit(GiaTourBiz dt)
        {
            string sql = "update GiaTour set giatri="+dt.giatri + ",dangapdung="+dt.dangapdung.ToString()+",thoigianbatdau=convert(date,'"+dt.thoigianbatdau.Date.ToShortDateString()+"',103),thoigianketthuc=convert(date,'"+dt.thoigianketthuc.Date.ToShortDateString()+"',103) where magia=N'"+dt.magia+"'";
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            try
            {
                Debug.WriteLine("edit GiaTour_" + sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                int rs = cmd.ExecuteNonQuery();
                this.qClose();
                if (rs == 0) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("GiaTour Edit failed!");
                return false;
            }
        }
        public Boolean delete(GiaTourBiz dt)
        {
            string sql = "delete from GiaTour where magia=N'" + dt.magia+ "'";
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            try
            {
                Debug.WriteLine("delete GiaTour_" + sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                int rs = cmd.ExecuteNonQuery();
                this.qClose();
                if (rs == 0) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("GiaTour delete failed!");
                return false;
            }
        }
    }
}