using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoModel;

public partial class Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //int debug = DataPager1.PageSize;
        /*
        if (!IsPostBack)
        {
            DemoEntities demoEntities = new DemoEntities();
            var items = from item in demoEntities.Items
                        select item;
            ListView1.DataSource = items;
            ListView1.DataBind();
        }
         */ 
        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataPager1.SetPageProperties(0, DataPager1.PageSize, true);
        
        LinqDataSource1.Where = "ItemName.Contains(@itemName)";
        LinqDataSource1.WhereParameters.Clear();
        LinqDataSource1.WhereParameters.Add("itemName", TextBox1.Text);
        
        //int debug = 0;        
    }
}