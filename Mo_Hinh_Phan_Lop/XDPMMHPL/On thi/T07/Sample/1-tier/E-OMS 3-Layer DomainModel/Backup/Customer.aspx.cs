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

using DomainModel.BL;

namespace DomainModel
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
            Customer customer = new Customer();
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.PhoneNumber = txtPhoneNo.Text;
            customer.Add();
            
        }

        private void ShowCustomer(int customerID)
        {
            Customer cu = new Customer();
            cu.ID = customerID;
            cu.Load();
            txtAddress.Text = cu.Address;
            txtName.Text = cu.Name;
            txtPhoneNo.Text = cu.PhoneNumber;
            txtPassword.Text = cu.Password;
            txtUsername.Text = cu.UserName;
            txtEmail.Text = cu.UserName;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();  
            customer.ID = Convert.ToInt32(Request.QueryString["cid"]);
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.PhoneNumber = txtPhoneNo.Text;
            customer.Password = txtPassword.Text;
            customer.UserName = txtUsername.Text;
            customer.Email = txtEmail.Text;
            customer.Update();
            Response.Redirect("~/showall.aspx");
        }
    }
}
