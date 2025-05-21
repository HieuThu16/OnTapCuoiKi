using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourDuLich.Biz;
using System.Data.SqlClient;

namespace TourDuLich.Dal
{
    class DalTour
    {
        internal static List<TourDuLich.Biz.BizTour> GetAll()
        {
            List<BizTour> result = new List<BizTour>();

            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("select * from Tour", conn);

                // get query results
                rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {                    
                    BizTour tour = new BizTour(rdr.GetInt32(2),
                        rdr.GetString(0), rdr.GetString(1),
                        rdr.GetBoolean(4), DalTour.GetLoaiTourById(rdr.GetInt32(3)));

                    result.Add(tour);
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

        private static BizLoaiTour GetLoaiTourById(int id)
        {
            BizLoaiTour result = null;

            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format("select * from LoaiTour where Id={0}", id);
                SqlCommand cmd = new SqlCommand(s, conn);

                // get query results
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    result = new BizLoaiTour(rdr.GetInt32(0)
                        , rdr.GetString(1), rdr.GetString(2));
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

        internal static void Delete(BizTour bizTour)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format("delete Tour where id={0}", bizTour.Id);
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

        internal static List<BizLoaiTour> GetAllLoaiTour()
        {
            List<BizLoaiTour> result = new List<BizLoaiTour>();

            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("select * from LoaiTour", conn);

                // get query results
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {                    
                    result.Add(new BizLoaiTour(rdr.GetInt32(0)
                        , rdr.GetString(1), rdr.GetString(2)));
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

        internal static List<BizGiaTour> GetGiaByTour(BizTour bizTour)
        {
            List<BizGiaTour> result = new List<BizGiaTour>();

            TourDBEntities tourDB = new TourDBEntities();

            result = (from t in tourDB.Tours
                      from g in t.GiaTours
                      select new BizGiaTour()
                      {
                          Id = g.Id,
                          giaTri = g.GiaTri,
                          ThoiGianBatDau = g.ThoiGianBatDau,
                          ThoiGianKetThuc = g.ThoiGianKetThuc,
                          DangApDung = g.DangApDung
                      }).ToList<BizGiaTour>();

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
                string s = String.Format("select * from GiaTour where TourId = {0}", bizTour.Id);
                SqlCommand cmd = new SqlCommand(s, conn);

                // get query results
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {                    
                    BizGiaTour gia = new BizGiaTour(rdr.GetInt32(0),
                        rdr.GetBoolean(4), rdr.GetDecimal(1),
                        rdr.GetDateTime(2), rdr.GetDateTime(3),
                        bizTour);
                    result.Add(gia);
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

        internal static int InsertNewTour(BizTour bizTour)
        {
            int result = bizTour.Id;

            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");
            SqlDataReader rdr = null;
            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format(@"insert into Tour(MaTour, 
                    TenTour, LoaiTourId, LaTourTrongNuoc) 
                    values('{0}', '{1}', {2}, '{3}')",
                    bizTour.MaTour, bizTour.TenTour, bizTour.LoaiTour.Id,
                    bizTour.LaTourTrongNuoc);
                SqlCommand cmd = new SqlCommand(s, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    s = String.Format("select Id from Tour where MaTour='{0}'", bizTour.MaTour);
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

            return result;
        }

        internal static void DeleteGiaByTour(BizTour bizTour)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format("delete GiaTour where TourId={0}", 
                    bizTour.Id);
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

        internal static void DeleteDiaDiemByTour(BizTour bizTour)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Format(@"delete DanhSachDiemThamQuan 
                    where TourId={0}", bizTour.Id);
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

        internal static void InsertGiaByTour(BizTour bizTour)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Empty;
                foreach (BizGiaTour gia in bizTour.Gias)
                {
                    s += String.Format(@"insert into GiaTour(GiaTri, 
                    ThoiGianBatDau, ThoiGianKetThuc, DangApDung, TourId) 
                    values({0}, '{1}', '{2}', '{3}', {4})",
                    gia.GiaTri, gia.ThoiGianBatDau.ToString("yyyy/MM/dd"),
                    gia.ThoiGianKetThuc.ToString("yyyy/MM/dd"),
                    gia.DangApDung, bizTour.Id);
                    s += " ; ";
                }

                if (s != String.Empty)
                {
                    SqlCommand cmd = new SqlCommand(s, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                    }
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

        internal static void InsertDiaDiemByTour(BizTour bizTour)
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                @"Data Source=CAOTH-LAPTOP\SQLEXPRESS2K5_2N;Initial Catalog=TourDB;User ID=sa;Password=sa");

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                String s = String.Empty;
                int i = 0;
                foreach (BizDiaDiem dd in bizTour.DiaDiems)
                {
                    s += String.Format(@"insert into DanhSachDiemThamQuan(
                    TourId, DiaDiemId, Stt)                     
                    values({0}, {1}, {2})",
                    bizTour.Id, dd.Id, i);
                    s += " ; ";
                    i++;
                }

                if (s != String.Empty)
                {
                    SqlCommand cmd = new SqlCommand(s, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                    }
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
    }
}
