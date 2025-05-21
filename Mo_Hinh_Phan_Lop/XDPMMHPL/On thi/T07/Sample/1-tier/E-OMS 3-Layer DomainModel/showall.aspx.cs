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
using System.Collections.Generic;


using DomainModel.BL;
namespace DomainModel.UI
{
    public partial class showall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            if (!IsPostBack)
            {
                FillAllCustomers();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/customer.aspx");
        }

        protected void rptCustomers_ItemCommand(object source, RepeaterCommandEventArgs e)
        {           
            if (e.CommandName == "Delete")
            {
                //RepeaterItem debug = e.Item;
                //int idebug = 0;

                //rptCustomers.DataSource
                
                Customer customer = new Customer();
                customer.ID = Convert.ToInt32(e.CommandArgument);
                customer.Delete();
                FillAllCustomers();                
            }
        }

        private void FillAllCustomers()
        {
            Customer c = new Customer();
            c.GetAll();
            List<Customer> cuList = c.CustomerCollection;
            rptCustomers.DataSource = cuList;
            rptCustomers.DataBind();
        }
    }
}
