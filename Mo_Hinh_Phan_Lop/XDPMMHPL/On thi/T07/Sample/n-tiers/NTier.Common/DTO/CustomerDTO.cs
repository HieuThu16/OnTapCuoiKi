
#region Using directives
using System;
using System.Collections.Generic;
#endregion

namespace NTier.Common
{
	/// <summary>
	///	DTO for the 'Customer' object.
	/// </summary>
	[Serializable]
	public class CustomerDTO
	{
	    #region Constructors
	    ///<summary>
		/// Default constructor
		///</summary>
	    public CustomerDTO()
		{
		  this.loadStatus = LoadStatus.Initialized;
		}
		
		///<summary>
		/// Copy constructor
		///</summary>
	    public CustomerDTO(CustomerDTO sourceDTO)
		{
            loadStatus = sourceDTO.loadStatus;
			ID = sourceDTO.ID;
		    Name = sourceDTO.Name;
		    Address = sourceDTO.Address;
		    PhoneNo = sourceDTO.PhoneNo;
		    UserName = sourceDTO.UserName;
		    Password = sourceDTO.Password;
		    Email = sourceDTO.Email;
		}
		#endregion
		
		#region Public Variable Declarations
		
		public  LoadStatus loadStatus;
		
		#region Primary key(s)
			/// <summary>			
			/// ID : 
			/// </summary>
			/// <remarks>Member of the primary key of the underlying table "OMS_Customer"</remarks>
			public System.Int32 ID;
				
		#endregion
		
		#region Non-Primary key(s)


		/// <summary>
		/// Name : 
		/// </summary>
		public System.String  Name = null;
		
		/// <summary>
		/// Address : 
		/// </summary>
		public System.String  Address = null;
		
		/// <summary>
		/// PhoneNo : 
		/// </summary>
		public System.String  PhoneNo = null;
		
		/// <summary>
		/// UserName : 
		/// </summary>
		public System.String  UserName = null;
		
		/// <summary>
		/// Password : 
		/// </summary>
		public System.String  Password = null;
		
		/// <summary>
		/// Email : 
		/// </summary>
		public System.String  Email = null;

		#endregion
			
		#endregion Variable Declarations

	}//end class
}//end namespace

