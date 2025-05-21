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
    public class DanhSachDDDAL
    {
        private SqlConnection con = new SqlConnection();
        public DanhSachDDDAL()
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
        public List<DiaDiemBiz> getAll(String matour)
        {
            string sql1 = "select DanhSachDD.madiadiem from DanhSachDD where matour=N'"+matour+"' order by thutu";
            string sql2 = "select * from DiaDiem where madiadiem in(";
            Boolean ok=this.qOpen();
            if (ok == false) return null;
            try
            {
                Debug.WriteLine("GetAll DS Địa điểm sql1_"+sql1);
                SqlCommand cmd = new SqlCommand(sql1, this.con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows) { this.qClose(); return new List<DiaDiemBiz>(); }
                List<DiaDiemBiz> list = new List<DiaDiemBiz>();
                    while (reader.Read())
                    {
                        DiaDiemBiz dt = new DiaDiemBiz();
                        dt.madiadiem = reader[0].ToString();
                       sql2 += "'" + dt.madiadiem.ToString() + "',";
                        list.Add(dt);
                    }
                sql2 += "'')";
                this.qClose();
                Debug.WriteLine("GetAll DS Địa điểm + sql2_" + sql2);
                this.qOpen();
                cmd.CommandText = sql2;
                SqlDataReader reader1 = cmd.ExecuteReader();
                if (!reader1.HasRows) return new List<DiaDiemBiz>();
                while (reader1.Read())
                {
                    foreach (DiaDiemBiz dd in list)
                    {
                        if (dd.madiadiem.Equals(reader1[1].ToString()))
                        {
                            dd.tendiadiem = reader1[2].ToString();
                            break;
                        }
                    }
                }
                this.qClose();
                return list;
            }
            catch
            {
                this.qClose();
                Debug.WriteLine("Dia Diem getAll() failed!");
                return new List<DiaDiemBiz>();
            }
        }
        public Boolean Insert(TourBiz dt)
        {
            Boolean ok=this.qOpen();
            if (ok == false) return false;
            int i = 1;
            int kq = 0;
            foreach (DiaDiemBiz d in dt.ds_diadiem)
            {
                string sql = "insert into DanhSachDD (matour,madiadiem,thutu) values(N'" + dt.matour + "',N'" + d.madiadiem + "'," + i + ")";
                try
                {
                    Debug.WriteLine("Insert Danh sách DD_" + sql);
                    SqlCommand cmd = new SqlCommand(sql, this.con);
                    int rs = cmd.ExecuteNonQuery();
                    if (rs == 0) return false;
                    kq += rs;
                }
                catch
                {
                    Debug.WriteLine("Danh sach DD insert failed!");
                    return false;
                }
                i++;
            }
            this.qClose();
            if (kq == dt.ds_diadiem.Count) return true;
            else
            {
                Debug.WriteLine("Không thêm đủ ds địa điểm");
                return false;
            }
        }
        public Boolean Edit(TourBiz dt)
        {
            Debug.WriteLine("Danh sách địa điểm edit");
            if (this.delete(dt))
            {
                if (this.Insert(dt)) return true;
                else { Debug.WriteLine("edit DSDD_insert failed!"); return false; }
            }
            else { Debug.WriteLine("edit DSDD_delete failed!"); return false; }
        }
        public Boolean delete(TourBiz dt)
        {
            if (this.getAll(dt.matour).Count <= 0) return true;
            string sql = "delete from DanhSachDD where matour=N'" + dt.matour + "'";
            Boolean ok = this.qOpen();
            if (ok == false) return false;
            try
            {
                Debug.WriteLine("delete danh sách Địa điểm_" + sql);
                SqlCommand cmd = new SqlCommand(sql, this.con);
                int rs = cmd.ExecuteNonQuery();
                this.qClose();
                if (rs == 0) return false;
                return true;
            }
            catch
            {
                Debug.WriteLine("Danh sách địa điểm delete failed!");
                return false;
            }
        }
    }
}
