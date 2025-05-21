using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace OMS.Code
{
    public class DAL
    {
        /// <summary>
        /// Load all Products from the DB
        /// </summary>
        public static DataTable GetAllProducts()
        {
            try
            {
                string sCon = ConfigurationManager.ConnectionStrings["DBConnString"].ConnectionString;
                using (SqlConnection cn = new SqlConnection(sCon))
                {
                    string sQuery = @"SELECT * FROM OMS_Product";
                    SqlCommand cmd = new SqlCommand(sQuery, cn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    cn.Open();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }//end class
}//end namespace
