using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DomainModel.DAL;

namespace DomainModel.BL
{
    /// <summary>
    /// Business Layer class
    /// </summary>
    public class Customer
    {
        #region Private Members
        private int _ID;
        private string _name;
        private string _address;
        private string _phoneNumber;
        private string _email;
        private string _password;
        private string _userName;
        private List<Customer> _customerCollection;
        #endregion

        #region Public properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }        

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }        

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public List<Customer> CustomerCollection
        {
            get { return _customerCollection; }
            set { _customerCollection = value; }
        }

        #endregion

        public void Add()
        {
            CustomerDAL.AddCustomer(this);
        }

        public void Delete()
        {
            CustomerDAL.DeleteCustomer(this);
        }

        public void Update()
        {
           CustomerDAL.UpdateCustomer(this);

        }

        public  void Load()
        {
            CustomerDAL.GetCustomer(this);
        }
            
       public void GetAll()
        {
            this.CustomerCollection = CustomerDAL.GetAllCustomers();
        } 

    }//end class
}//end namespace
