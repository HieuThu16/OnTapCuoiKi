

#region using directives
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using System.Collections;
using System.Collections.ObjectModel;

using System.Diagnostics;
using NTier.Common;

#endregion

namespace NTier.DAL
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="Customer"/> entity.
	///</summary>

	public class CustomerDAL
	{
		#region Insert Customer		
		/// <summary>
		/// Inserts a Customer object into the database.
		/// </summary>
		/// <param name="entity">Customer object to insert.</param>
		/// <remarks>
		///	After inserting into the datasource, the Customer object will be updated
		/// to refelect any changes made by the database. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        public static bool AddCustomer(CustomerDTO entity)
		{
		 try
		   {
		    string strCommandText = "OMS_Customer_Insert";
		    using(SqlConnection cn = new SqlConnection(SQLHelper.GetConnectionString()))
	     	{
			   SqlCommand cmd = new SqlCommand(strCommandText, cn);
			   cmd.CommandType = CommandType.StoredProcedure;
				 SqlParameter paramID = new SqlParameter("@ID",  SqlDbType.Int, 4);
                 paramID.Direction = ParameterDirection.Output;
                 cmd.Parameters.Add(paramID);					
				
				 SqlParameter paramName = new SqlParameter("@Name",  SqlDbType.VarChar, 255);
                 paramName.Value = entity.Name;
                 cmd.Parameters.Add(paramName);					
				
				 SqlParameter paramAddress = new SqlParameter("@Address",  SqlDbType.VarChar, 255);
                 paramAddress.Value = entity.Address;
                 cmd.Parameters.Add(paramAddress);					
				
				 SqlParameter paramPhoneNo = new SqlParameter("@PhoneNo",  SqlDbType.VarChar, 20);
                 paramPhoneNo.Value = entity.PhoneNo;
                 cmd.Parameters.Add(paramPhoneNo);					
				
				 SqlParameter paramUserName = new SqlParameter("@UserName",  SqlDbType.VarChar, 255);
                 paramUserName.Value = entity.UserName;
                 cmd.Parameters.Add(paramUserName);					
				
				 SqlParameter paramPassword = new SqlParameter("@Password",  SqlDbType.VarChar, 255);
                 paramPassword.Value = entity.Password;
                 cmd.Parameters.Add(paramPassword);					
				
				 SqlParameter paramEmail = new SqlParameter("@Email",  SqlDbType.VarChar, 255);
                 paramEmail.Value = entity.Email;
                 cmd.Parameters.Add(paramEmail);					
				
			     int results = 0;
				 cn.Open();
			     results = cmd.ExecuteNonQuery();

			     entity.ID = (System.Int32) paramID.Value;						
			     return Convert.ToBoolean(results);
			}
		  }
			 catch (Exception ex)
            {
                throw;
            }
		}
		#endregion
		
        #region Update Customer				
		/// <summary>
		/// Update an existing row in the database.
		/// </summary>
		/// <param name="entity">Customer object to update.</param>>
		public static bool UpdateCustomer(CustomerDTO entity)
		{
    	 try
		   {
		    string strCommandText = "OMS_Customer_Update";
		    using(SqlConnection cn = new SqlConnection(SQLHelper.GetConnectionString()))
	     	{
               SqlCommand cmd = new SqlCommand(strCommandText, cn);
			   cmd.CommandType = CommandType.StoredProcedure;
				 SqlParameter paramID = new SqlParameter("@ID", SqlDbType.Int, 4);
                 paramID.Value = entity.ID;
                 cmd.Parameters.Add(paramID);					
				
				 SqlParameter paramName = new SqlParameter("@Name", SqlDbType.NVarChar, 255);
                 paramName.Value = entity.Name;
                 cmd.Parameters.Add(paramName);					
				
				 SqlParameter paramAddress = new SqlParameter("@Address", SqlDbType.NVarChar, 255);
                 paramAddress.Value = entity.Address;
                 cmd.Parameters.Add(paramAddress);					
				
				 SqlParameter paramPhoneNo = new SqlParameter("@PhoneNo", SqlDbType.NVarChar, 20);
                 paramPhoneNo.Value = entity.PhoneNo;
                 cmd.Parameters.Add(paramPhoneNo);					
				
				 SqlParameter paramUserName = new SqlParameter("@UserName", SqlDbType.NVarChar, 255);
                 paramUserName.Value = entity.UserName;
                 cmd.Parameters.Add(paramUserName);					
				
				 SqlParameter paramPassword = new SqlParameter("@Password", SqlDbType.NVarChar, 255);
                 paramPassword.Value = entity.Password;
                 cmd.Parameters.Add(paramPassword);					
				
				 SqlParameter paramEmail = new SqlParameter("@Email", SqlDbType.NVarChar, 255);
                 paramEmail.Value = entity.Email;
                 cmd.Parameters.Add(paramEmail);					
				
			     int results = 0;
				 cn.Open();
			     results = cmd.ExecuteNonQuery();
			
			     return Convert.ToBoolean(results);
			}
		  }
			 catch (Exception ex)
            {
                throw;
            }
		}			
		#endregion
		
		#region Delete Customer
		/// <summary>
		/// Deletes a row from the DataSource.
		/// </summary>
		/// <param name="customerID">Customer ID to delete.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public static bool  DeleteCustomer(int customerID)
		{
			try
		   {
		    string strCommandText = "OMS_Customer_Delete";
		    using(SqlConnection cn = new SqlConnection(SQLHelper.GetConnectionString()))
	     	{
               SqlCommand cmd = new SqlCommand(strCommandText, cn);
			   cmd.CommandType = CommandType.StoredProcedure;
				 SqlParameter paramID = new SqlParameter("@ID",  SqlDbType.Int, 4);
                 paramID.Value = customerID;
                 cmd.Parameters.Add(paramID);					
			     int results = 0;
				 cn.Open();
			     results = cmd.ExecuteNonQuery();
			
			     return Convert.ToBoolean(results);
			}
		  }
			 catch (Exception ex)
            {
                throw;
            }
		}//end Delete
		#endregion

		#region Load Customer 				
		/// <summary>
		/// Laods a CustomerDTO object from the database based on the PK_IMS_Customer index.
		/// </summary>
		/// <param name="id"></param>
		/// <returns>Returns a single loaded instance of CustomerDTO object.</returns>
		/// <remarks></remarks>
		public static CustomerDTO LoadCustomer(System.Int32 id)
		{
		 try
		  {
		    string strCommandText = "OMS_Customer_SelectByCustomerID";
			CustomerDTO dto;
		    using(SqlConnection cn = new SqlConnection(SQLHelper.GetConnectionString()))
	     	{
               SqlCommand cmd = new SqlCommand(strCommandText, cn);
			   cmd.CommandType = CommandType.StoredProcedure;
				 SqlParameter paramID = new SqlParameter("@ID",  SqlDbType.Int, 4);
                 paramID.Value = id;
                 cmd.Parameters.Add(paramID);
			
			SqlDataReader reader = null;
			dto = new CustomerDTO();			
			cn.Open();
		    reader = cmd.ExecuteReader();
			if(reader.HasRows)
			  {
			    while(reader.Read())
				{				  
						dto.ID = (System.Int32)reader["ID"];
						dto.Name = (reader.IsDBNull(reader.GetOrdinal("Name")))?null:(System.String)reader["Name"];
						dto.Address = (reader.IsDBNull(reader.GetOrdinal("Address")))?null:(System.String)reader["Address"];
						dto.PhoneNo = (reader.IsDBNull(reader.GetOrdinal("PhoneNo")))?null:(System.String)reader["PhoneNo"];
						dto.UserName = (reader.IsDBNull(reader.GetOrdinal("UserName")))?null:(System.String)reader["UserName"];
						dto.Password = (reader.IsDBNull(reader.GetOrdinal("Password")))?null:(System.String)reader["Password"];
						dto.Email = (reader.IsDBNull(reader.GetOrdinal("Email")))?null:(System.String)reader["Email"];
				}
			  }
			}
			return dto;
		  }
		  catch(Exception ex)
		  {
			throw;
		  }
		}					
		#endregion		

        #region Get All	Customers Without Paging
        /// <summary>
        /// Gets all Customers from the database
        /// </summary>
        /// <param name="LoadStatus">Indicates full or partial/ghost loading</param>
        /// <returns>Returns a strongly typed list of CustomerDTO objects.</returns>
        /// <remarks></remarks>
        public static Collection<CustomerDTO> GetAllCustomersNoPaging(LoadStatus loadStatus)
        {
            try
            {
                string strCommandText = "OMS_Customer_SelectAll";
                Collection<CustomerDTO> list;
                using (SqlConnection cn = new SqlConnection(SQLHelper.GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand(strCommandText, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlDataReader reader = null;
                    list = new Collection<CustomerDTO>();

                    cn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Create collection and fill
                            CustomerDTO c = new CustomerDTO();

                            c.ID = (System.Int32)reader["ID"];
                            c.Name = (reader.IsDBNull(reader.GetOrdinal("Name"))) ? null : (System.String)reader["Name"];

                            if (loadStatus == LoadStatus.Loaded)
                            {
                                c.Address = (reader.IsDBNull(reader.GetOrdinal("Address"))) ? null : (System.String)reader["Address"];
                                c.PhoneNo = (reader.IsDBNull(reader.GetOrdinal("PhoneNo"))) ? null : (System.String)reader["PhoneNo"];
                                c.UserName = (reader.IsDBNull(reader.GetOrdinal("UserName"))) ? null : (System.String)reader["UserName"];
                                c.Password = (reader.IsDBNull(reader.GetOrdinal("Password"))) ? null : (System.String)reader["Password"];
                                c.Email = (reader.IsDBNull(reader.GetOrdinal("Email"))) ? null : (System.String)reader["Email"];
                            }
                            list.Add(c);
                        }
                    }
                    reader.Close();
                }

                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion		
		
		#region Get All	Customers Paged		
		/// <summary>
		/// Gets all Customers from the database
		/// </summary>
		/// <param name="LoadStatus">Indicates full or partial/ghost loading</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get number of page</param>
		/// <returns>Returns a strongly typed list of CustomerDTO objects.</returns>
		/// <remarks></remarks>
        public static Collection<CustomerDTO> GetAllCustomers(LoadStatus loadStatus, int startPage, int pageLength, out int noOfPages)
		{
		 try
		   {
		    string strCommandText = "OMS_Customer_SelectAllPaged";
			Collection<CustomerDTO> list;
		    using(SqlConnection cn = new SqlConnection(SQLHelper.GetConnectionString()))
	     	{
               SqlCommand cmd = new SqlCommand(strCommandText, cn);
			   cmd.CommandType = CommandType.StoredProcedure;

               SqlParameter paramStart = new SqlParameter("@startPage", SqlDbType.Int);
               paramStart.Value = startPage;
               cmd.Parameters.Add(paramStart);
				 
			   SqlParameter paramPageLength = new SqlParameter("@pageLength",  SqlDbType.Int);
               paramPageLength.Value = pageLength;
               cmd.Parameters.Add(paramPageLength);

			   SqlParameter paramNoOfPages = new SqlParameter("@NoOfPages",  SqlDbType.Int);
               paramNoOfPages.Direction = ParameterDirection.Output;
               cmd.Parameters.Add(paramNoOfPages);
			
			SqlDataReader reader = null;
			list = new Collection<CustomerDTO>();

			cn.Open();			
		    reader = cmd.ExecuteReader();
			if(reader.HasRows)
			  {
			    while(reader.Read())
				{
				  //Create collection and fill
				  CustomerDTO c = new CustomerDTO();
				
						c.ID = (System.Int32)reader["ID"];
						c.Name = (reader.IsDBNull(reader.GetOrdinal("Name")))?null:(System.String)reader["Name"];
					
					if(loadStatus==LoadStatus.Loaded)
					 {
						c.Address = (reader.IsDBNull(reader.GetOrdinal("Address")))?null:(System.String)reader["Address"];
						c.PhoneNo = (reader.IsDBNull(reader.GetOrdinal("PhoneNo")))?null:(System.String)reader["PhoneNo"];
						c.UserName = (reader.IsDBNull(reader.GetOrdinal("UserName")))?null:(System.String)reader["UserName"];
						c.Password = (reader.IsDBNull(reader.GetOrdinal("Password")))?null:(System.String)reader["Password"];
						c.Email = (reader.IsDBNull(reader.GetOrdinal("Email")))?null:(System.String)reader["Email"];
					}
				 list.Add(c);
				}              
			  }
                reader.Close();
                noOfPages = (int)paramNoOfPages.Value;
			}
        
			return list;
		}
		 catch(Exception ex)
		{
			throw;
		}
		}					
		#endregion		

	
	}//end class
} // end namespace

