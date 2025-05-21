


#region Using directives
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using NTier.DAL;
using NTier.Common;
#endregion

namespace NTier.BL
{
	/// <summary>
	///	Business class for the collection of  Customers.
	/// </summary>
	public class CustomerCollection : Collection<Customer>
	{		
		
		#region Constructor
		
		/// <summary>
		/// Do not expose List<T> because it exposes too many members, many of which are not relevant
		/// in most situations. In contrast, Collection<T> exposes only a small number. For those that are relevant,
		/// it is easy to encapsulate List<T> and expose those that you want to make use of via a class that derives
		/// from Collection<T> using base contructor so that the Collection can simply call the
		/// underlying List<T>'s Find (or any other useful method) implementation, saving you from having to implement your own.
		/// </summary>
		public CustomerCollection(): base(new List<Customer>())
		{
		  
		}
	
		#endregion
		
		#region  Public Methods
		
		#region Add
		/// <summary>
		/// Adds a new object state to the database
		/// </summary>
		/// <returns>bool</returns>
		public bool AddNew(Customer bo)
		{
			try
			{
				///<remark>
				///Add the  in the database
				///</remark>
				CustomerDAL.AddCustomer(bo.DTO);
				
				///<remarks>
				///Set load status to 'ghost' to mark that it needs to be fully loaded again
				///</remarks>
				bo.DTO.loadStatus=LoadStatus.Ghost;
				
				return true;
			}
			catch(Exception ex)
			{
                //handle exception 
				throw;
            }
		}
		#endregion		
				
		#region Delete
		/// <summary>
		/// Deletes a  object from the database
		/// </summary>
		/// <returns>bool</returns>
		public bool Delete(Customer bo)
		{
			try
			{
				CustomerDAL.DeleteCustomer(bo.ID);

				///<remarks>
			    ///Set load status to 'ghost' to mark that it needs to be fully loaded again
			    ///</remarks>
				bo.DTO.loadStatus=LoadStatus.Ghost;
				
				return true;
			}
			catch(Exception ex)
			{
                //handle exception 
				throw;
            }
		}
		#endregion
		
		#region Find All
		/// <summary>
		/// Returns a list of  objects from the database
		/// based on the parameter entered.
		/// </summary>
		/// <returns>Collection<Customer>a collection of customers</returns>
		public Collection<Customer> FindAll(LoadStatus loadStatus, int startPage,int pageLength, out int noOfPages)
		{
			try
			{
			   /*
				* Get the list of DTOs returned from the DAL and create a collection
				* of business objects by passing in DTOs in the domain object constructor
			    */
                Collection<CustomerDTO> dtoList = CustomerDAL.GetAllCustomers(loadStatus,startPage,pageLength, out noOfPages);
				 
				foreach(CustomerDTO dto in dtoList)
				 {
				    Customer customer = new Customer(dto);
				    this.Add(customer);				   
				 }
				 return this;			
				
			}
			catch(Exception ex)
			{
				//handle exception
				throw;
            }
		}
		#endregion

        #region Find All Without Paging
        /// <summary>
        /// Returns a list of  objects from the database
        /// based on the parameter entered.
        /// </summary>
        /// <returns>Collection<Customer>a collection of customers</returns>
        public Collection<Customer> FindAllNoPaging(LoadStatus loadStatus)
        {
            try
            {
                /*
                 * Get the list of DTOs returned from the DAL and create a collection
                 * of business objects by passing in DTOs in the domain object constructor
                 */
                Collection<CustomerDTO> dtoList = CustomerDAL.GetAllCustomersNoPaging(loadStatus);

                foreach (CustomerDTO dto in dtoList)
                {
                    Customer customer = new Customer(dto);
                    this.Add(customer);
                }
                return this;

            }
            catch (Exception ex)
            {
                //handle exception
                throw;
            }
        }
        #endregion

        #region Find Customer By ID
        /// <summary>
        /// Returns a single customer from the database
        /// based on the parameter entered.
        /// </summary>
        /// <returns>a single customer object with all details loaded</returns>
        public Customer FindByCustomerID(int customerID)
        {
            try
            {
                Customer customer = new Customer();
                CustomerDTO customerDTO = CustomerDAL.LoadCustomer(customerID);
                customer.DTO = customerDTO;

                return customer;
            }
            catch (Exception ex)
            {
                //handle exception
                throw;
            }
        }
        #endregion
		#endregion Public Methods
		

	}//end class
}//end namespace


