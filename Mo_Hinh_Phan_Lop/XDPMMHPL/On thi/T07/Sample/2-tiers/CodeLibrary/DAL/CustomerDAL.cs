using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using OMS.CodeTier.BL;

namespace OMS.CodeTier.DAL
{
    /// <summary>
    /// Data Access Layer class
    /// </summary>
    public class CustomerDAL
    {
        public static void AddCustomer(Customer cs)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SQLHelper.GetConnectionString()))
                {
                    SqlParameter[] par = new SqlParameter[7];
                    par[0] = new SqlParameter("@customerID", cs.ID);
                    par[0].Direction = ParameterDirection.Output;
                    par[1] = new SqlParameter("@name", cs.Name);
                    par[2] = new SqlParameter("@address", cs.Address);
                    par[3] = new SqlParameter("@phoneNo", cs.PhoneNumber);
                    par[4] = new SqlParameter("@password", cs.Password);
                    par[5] = new SqlParameter("@email", cs.Email);
                    par[6] = new SqlParameter("@userName", cs.UserName);
                    int rowNo = SQLHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "OMS_Customer_Insert", par);
                    cs.ID = Convert.ToInt32(par[0].Value);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void DeleteCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SQLHelper.GetConnectionString()))
                {
                    SqlParameter[] par = new SqlParameter[1];
                    par[0] = new SqlParameter("@ID", customer.ID);
                    int rowNo = SQLHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "OMS_Customer_Delete", par);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateCustomer(Customer cs)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SQLHelper.GetConnectionString()))
                {
                    SqlParameter[] par = new SqlParameter[7];
                    par[0] = new SqlParameter("@ID", cs.ID);
                    par[1] = new SqlParameter("@address", cs.Address);
                    par[2] = new SqlParameter("@name", cs.Name);
                    par[3] = new SqlParameter("@phoneNo", cs.PhoneNumber);
                    par[4] = new SqlParameter("@password", cs.Password);
                    par[5] = new SqlParameter("@email", cs.Email);
                    par[6] = new SqlParameter("@userName", cs.UserName);
                    int rowNo = SQLHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, "OMS_Customer_Update", par);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void GetCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SQLHelper.GetConnectionString()))
                {
                    SqlParameter[] par = new SqlParameter[1];
                    par[0] = new SqlParameter("@ID", customer.ID);
                    using (SqlDataReader dr = SQLHelper.ExecuteReader(con, CommandType.StoredProcedure, "OMS_Customer_SelectByCustomerID", par))
                    {
                        while (dr.Read())
                        {
                            customer.Name = SQLHelper.CheckStringNull(dr["Name"]);
                            customer.PhoneNumber = SQLHelper.CheckStringNull(dr["PhoneNo"]);
                            customer.Address = SQLHelper.CheckStringNull(dr["Address"]);
                            customer.ID = SQLHelper.CheckIntNull(dr["ID"]);
                            customer.Email = SQLHelper.CheckStringNull(dr["Email"]);
                            customer.Password = SQLHelper.CheckStringNull(dr["Password"]);
                            customer.UserName = SQLHelper.CheckStringNull(dr["UserName"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<Customer> GetAllCustomers()
        {
            try
            {
                List<Customer> cuList = new List<Customer>();
                using (SqlConnection con = new SqlConnection(SQLHelper.GetConnectionString()))
                {
                    using (SqlDataReader dr = SQLHelper.ExecuteReader(con, CommandType.StoredProcedure, "OMS_Customer_SelectAll"))
                    {
                        while (dr.Read())
                        {
                            Customer customer = new Customer();
                            customer.Name = SQLHelper.CheckStringNull(dr["Name"]);
                            customer.PhoneNumber = SQLHelper.CheckStringNull(dr["PhoneNo"]);
                            customer.Address = SQLHelper.CheckStringNull(dr["Address"]);
                            customer.ID = SQLHelper.CheckIntNull(dr["ID"]);
                            cuList.Add(customer);
                        }
                    }
                }
                return cuList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }//end class
}//end namespace
