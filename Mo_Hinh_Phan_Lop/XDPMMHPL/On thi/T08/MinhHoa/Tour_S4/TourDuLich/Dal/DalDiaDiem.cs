using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourDuLich.Biz;
using System.Data.SqlClient;

namespace TourDuLich.Dal
{
    class DalDiaDiem
    {
        internal static List<TourDuLich.Biz.BizDiaDiem> GetAll()
        {
            List<BizDiaDiem> result = new List<BizDiaDiem>();

            TourDBEntities entities = new TourDBEntities();            
            result = (from dd in entities.DiaDiems
                      select new BizDiaDiem()
                      {
                          Id = dd.Id,
                          MaDD = dd.MaDiaDiem,
                          TenDD = dd.TenDiaDiem
                      }).ToList<BizDiaDiem>();

            /*
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("select * from DiaDiem", conn);

                // get query results
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    BizDiaDiem dd = new BizDiaDiem(rdr.GetInt32(2), 
                        rdr.GetString(0), rdr.GetString(1));
                    result.Add(dd);
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            */

            return result;
        }

        internal static int Add(BizDiaDiem bizDiaDiem)
        {
            int result = bizDiaDiem.Id;

            DiaDiem dd = new DiaDiem();
            dd.MaDiaDiem = bizDiaDiem.MaDD;
            dd.TenDiaDiem = bizDiaDiem.TenDD;

            TourDBEntities entities = new TourDBEntities();
            entities.AddToDiaDiems(dd);

            entities.SaveChanges();

            result = dd.Id;

            /*
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format("insert into DiaDiem(MaDiaDiem, TenDiaDiem) values('{0}', '{1}')",
                    bizDiaDiem.MaDD, bizDiaDiem.TenDD);
                SqlCommand cmd = new SqlCommand(s, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    s = String.Format("select Id from DiaDiem where MaDiaDiem='{0}'", bizDiaDiem.MaDD);
                    cmd.CommandText = s;
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        result = Int32.Parse(rdr["Id"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            */
            return result;
        }

        internal static void Update(BizDiaDiem bizDiaDiem)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format("update DiaDiem set MaDiaDiem = '{0}', TenDiaDiem = N'{1}' where id={2}", 
                    bizDiaDiem.MaDD, bizDiaDiem.TenDD, bizDiaDiem.Id);
                SqlCommand cmd = new SqlCommand(s, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    // todo if neccesary
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        internal static void Delete(BizDiaDiem bizDiaDiem)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format("delete DiaDiem where id={0}", 
                    bizDiaDiem.Id);
                SqlCommand cmd = new SqlCommand(s, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                }
            }
            finally
            {
                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        internal static List<BizDiaDiem> GetDiaDiemByTour(BizTour bizTour)
        {
            List<BizDiaDiem> result = new List<BizDiaDiem>();

            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                string s = String.Format(@"select dd.Id, dd.MaDiaDiem, dd.TenDiaDiem, dtq.Stt 
                            from DanhSachDiemThamQuan dtq, DiaDiem dd 
                            where TourId = {0} and dtq.DiaDiemId = dd.Id 
                            order by dtq.Stt", bizTour.Id);
                SqlCommand cmd = new SqlCommand(s, conn);

                // get query results
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    BizDiaDiem dd = new BizDiaDiem(rdr.GetInt32(0),
                        rdr.GetString(1), rdr.GetString(2));
                    result.Add(dd);
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return result;
        }
    }
}
