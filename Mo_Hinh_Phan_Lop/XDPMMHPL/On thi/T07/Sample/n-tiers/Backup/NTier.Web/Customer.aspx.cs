using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using NTier.BL;
using NTier.Common;

namespace NTier.Web
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cid"]))
                {
                    ShowCustomer(Convert.ToInt32(Request.QueryString["cid"]));
                }
                else
                {
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                }
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCollection customers = new CustomerCollection();
                Customer customer = new Customer();
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.PhoneNo = txtPhoneNo.Text;
                customer.UserName = txtUsername.Text;
                customer.Email = txtEmail.Text;
                customer.Password = txtPassword.Text;
                customers.AddNew(customer);
                Response.Redirect("~/showall.aspx");
            }
            catch (Exception ex)
            {
                //handle expcetion here instead of throwing it
                throw;
            }
        }

        private void ShowCustomer(int customerID)
        {
            try
            {
                CustomerCollection customers = new CustomerCollection();
                Customer customer = customers.FindByCustomerID(customerID);
                txtAddress.Text = customer.Address;
                txtName.Text = customer.Name;
                txtPhoneNo.Text = customer.PhoneNo;
                txtPassword.Text = customer.Password;
                txtUsername.Text = customer.UserName;
                txtEmail.Text = customer.Email;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
            catch (Exception ex)
            {
                //handle expcetion here instead of throwing it
                throw;
            }            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();  
            customer.ID = Convert.ToInt32(Request.QueryString["cid"]);
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.PhoneNo = txtPhoneNo.Text;
            customer.Password = txtPassword.Text;
            customer.UserName = txtUsername.Text;
            customer.Email = txtEmail.Text;
            customer.LoadStatus = LoadStatus.Loaded;
            customer.Update();
            Response.Redirect("~/showall.aspx");
        }
    }//end class
}//end namespace
