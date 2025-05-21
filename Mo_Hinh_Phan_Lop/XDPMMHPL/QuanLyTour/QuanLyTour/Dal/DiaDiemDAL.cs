using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using QuanLyTour.Biz;

namespace QuanLyTour.Dal
{
    class DiaDiemDAL
    {
        private SqlConnection con = new SqlConnection();
        public DiaDiemDAL()
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
        public List<DiaDiemBiz> getAll()
        {
            string sql = "select * from DiaDiem order by id_diadiem asc";
            Boolean ok=this.qOpen();
            if (ok == false) return null;
            try
            {
                Debug.WriteLine("GetAll Địa điểm_"+sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) return new List<DiaDiemBiz>();
                List<DiaDiemBiz> list = new List<DiaDiemBiz>();
                    while (reader.Read())
                    {
                        DiaDiemBiz dt = new DiaDiemBiz();
                        dt.madiadiem = reader[1].ToString();
                        dt.tendiadiem = reader[2].ToString();
                  //      Debug.WriteLine(dt.madiadiem+"_"+dt.tendiadiem);
                        list.Add(dt);
                    }
                this.qClose();
                return list;
            }
            catch
            {
                Debug.WriteLine("Dia Diem getAll() failed!");
                return new List<DiaDiemBiz>();
            }
        }
        public Boolean check_ma(String ma)
        {
            string sql = "select * from DiaDiem where madiadiem=N'" + ma + "'";
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
        public Boolean Insert(DiaDiemBiz dt)
        {
            string sql = "insert into DiaDiem (madiadiem,tendiadiem) values(N'"+dt.madiadiem+"',N'"+dt.tendiadiem+"')";
             Boolean ok=this.qOpen();
             if (ok == false) return false;
            try
            {
                Debug.WriteLine("Insert Địa điểm_"+sql);
                SqlCommand cmd = new SqlCommand(sql,this.con);
                int rs=cmd.ExecuteNonQuery();
                this.qClose();
                if (rs == 0) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("Dia Diem insert failed!");
                return false;
            }
        }
        public Boolean Edit(DiaDiemBiz dt)
        {
            string sql = "update DiaDiem set tendiadiem=N'"+dt.tendiadiem + "' where madiadiem=N'"+dt.madiadiem+"'";
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            try
            {
                Debug.WriteLine("edit Địa điểm_" + sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                int rs = cmd.ExecuteNonQuery();
                this.qClose();
                if (rs == 0) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("Dia Diem Edit failed!");
                return false;
            }
        }
        public Boolean delete(DiaDiemBiz dt)
        {
            string sql = "delete from DiaDiem where madiadiem=N'" + dt.madiadiem + "'";
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            try
            {
                Debug.WriteLine("delete Địa điểm_" + sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                int rs = cmd.ExecuteNonQuery();
                this.qClose();
                if (rs == 0) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("Dia Diem delete failed!");
                return false;
            }
        }
    }
}
