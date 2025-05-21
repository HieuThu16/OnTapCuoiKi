


#region Using directives
using System;
using System.Collections.Generic;

using NTier.Common;
using NTier.DAL;
#endregion

namespace NTier.BL
{
	/// <summary>
	///	Business class for the 'Customer' .
	/// </summary>
	public class Customer
	{		
		#region Private Members
		private CustomerDTO _customerDTO;
		#endregion
		
		#region Constructors
		
		#region Default Constructor
		/// <summary>
		/// Default Constructor initializes
		/// a new DTO object so that the business  
		/// object is ready to be used.
		/// </summary>
		public Customer()
		{
		  _customerDTO = new CustomerDTO();
		}
	
		#endregion
		
		#region Copy Constructor
		/// <summary>
		/// Copy Constructor initializes new business
		/// object by copying exisitng DTO to a
		/// a new DTO object
		/// </summary>
		public Customer(CustomerDTO _sourceDTO)
		{
		  _customerDTO = new CustomerDTO(_sourceDTO);
		}
		#endregion
		
		#endregion
		
		#region Public Properties
		
		public CustomerDTO DTO
		{
		  get { return _customerDTO ; }
		  set { _customerDTO = value ;}
		}
		
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "OMS_Customer"</remarks>
		public System.Int32 ID
		{
		  get { return _customerDTO.ID; }
		  set { _customerDTO.ID = value; }
		}

        public LoadStatus  LoadStatus
        {
            get
            {
                return _customerDTO.loadStatus;
            }
            set { _customerDTO.loadStatus = value; }
        }

		/// <summary>
		/// Name : 
		/// </summary>
		public System.String  Name 
		{
		   get 
		    { 
			  Load();
		      return  _customerDTO.Name;
			}
		   set { _customerDTO.Name  = value;}
		}
		
		/// <summary>
		/// Address : 
		/// </summary>
		public System.String  Address 
		{
		   get 
		    { 
			  Load();
		      return  _customerDTO.Address;
			}
		   set { _customerDTO.Address  = value;}
		}
		
		/// <summary>
		/// PhoneNo : 
		/// </summary>
		public System.String  PhoneNo 
		{
		   get 
		    { 
			  Load();
		      return  _customerDTO.PhoneNo;
			}
		   set { _customerDTO.PhoneNo  = value;}
		}
		
		/// <summary>
		/// UserName : 
		/// </summary>
		public System.String  UserName 
		{
		   get 
		    { 
			  Load();
		      return  _customerDTO.UserName;
			}
		   set { _customerDTO.UserName  = value;}
		}
		
		/// <summary>
		/// Password : 
		/// </summary>
		public System.String  Password 
		{
		   get 
		    { 
			  Load();
		      return  _customerDTO.Password;
			}
		   set { _customerDTO.Password  = value;}
		}
		
		/// <summary>
		/// Email : 
		/// </summary>
		public System.String  Email 
		{
		   get 
		    { 
			  Load();
		      return  _customerDTO.Email;
			}
		   set { _customerDTO.Email  = value;}
		}
		
		
		#endregion Public Properties
		
		
		#region Private Methods
		/// <summary>
		/// Helper function used in lazy load; if the load state
		/// is "Ghost" (partial loaded) then do a full load
		/// </summary>
		private void Load()
		{
		  try
			{
				if( _customerDTO.loadStatus == LoadStatus.Ghost) 
				{
					_customerDTO=CustomerDAL.LoadCustomer(_customerDTO.ID);
					_customerDTO.loadStatus = LoadStatus.Loaded ;  
				}
			}
		  catch(Exception ex)
			{
				//LoggerFactory.GetLogger().LogAndRethrowException(GetType(),ex,ExceptionID.TechnologyLoadFailed);
				throw;
			}
		}
		
		#endregion Private Methods
		
		#region  Public Methods
		
		#region Update
		/// <summary>
		/// Updates object state into database
		/// </summary>
		/// <returns>bool</returns>
		public bool Update()
		{
			try
			{
				///<remark>
				///Check for the load status to make sure that update is not 
				///being called on disconnected/'ghost' loaded objects. 
				///</remark>
				if( _customerDTO.loadStatus == LoadStatus.Loaded)    
				{
					CustomerDAL.UpdateCustomer(_customerDTO);
	
					///<remarks>
				    ///Set load status to 'ghost' to mark that it needs to be fully loaded again
				    ///</remarks>
					_customerDTO.loadStatus=LoadStatus.Ghost;
					return true;
				}
				else
				{
				    return false;
				}
			}
			catch(Exception ex)
			{
				//LoggerFactory.GetLogger().LogAndRethrowException(GetType(),ex,ExceptionID.TechnologyUpdateFailed); 
				throw;
            }
		}
		#endregion
		
		
		#endregion Public Methods
		

	}//end class
}//end namespace


