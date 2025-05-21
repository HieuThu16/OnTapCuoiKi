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


using NTier.BL;
using NTier.Common;

namespace NTier.Web
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
                CustomerCollection customers = new CustomerCollection();
                Customer customer = new Customer();
                customer.ID = Convert.ToInt32(e.CommandArgument);
                customers.Delete(customer);
                FillAllCustomers();
            }
        }

        /// <summary>
        /// Get and Show a list of all customers
        /// </summary>
        private void FillAllCustomers()
        {
            pager1.PageSize = 5;
            CustomerCollection customers = new CustomerCollection();            
            //from which page number to start fetching the records
            int startPage = pager1.CurrentIndex;
            //no. of records per page
            int pageLength = pager1.PageSize;
            //how many pages are in there total, output parameter set by DB code
            int noOfPages;            
            rptCustomers.DataSource = customers.FindAll(LoadStatus.Loaded, startPage, pageLength, out noOfPages);
            rptCustomers.DataBind();

            //set the pager        
            
            pager1.ItemCount = noOfPages * pageLength;
        }

        public void pager_Command(object sender, CommandEventArgs e)
        {
            int currnetPageIndx = Convert.ToInt32(e.CommandArgument);
            pager1.CurrentIndex = currnetPageIndx;
            FillAllCustomers();
        }

    }//end class
}//end namespace
