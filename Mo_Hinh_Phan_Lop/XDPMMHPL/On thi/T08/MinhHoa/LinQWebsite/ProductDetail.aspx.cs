using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoModel;

public partial class ProductDetail : System.Web.UI.Page
{
    DemoEntities demoEntities = new DemoEntities();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {

    }
    protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
    {        
        try
        {
            Item item = new Item();
            item.ItemName = e.Values["ItemName"].ToString();
            item.CategoryId = Int32.Parse(e.Values["CategoryId"].ToString());
            item.ImageUrl = "You need to do something here...";

            demoEntities.AddToItems(item);
            demoEntities.SaveChanges();

            Response.Redirect("~/Product.aspx");
        }
        catch (Exception ex)
        {
            //ex.Message
        }
        finally
        {
            e.Cancel = true;
        }
    }
    protected void FormView1_ItemUpdating(object sender, FormViewUpdateEventArgs e)
    {
        int itemId = (int)e.Keys[0];

        var item = (from i in demoEntities.Items
                    where i.ItemId == itemId
                    select i).SingleOrDefault<Item>();        

        try
        {
            item.ItemName = e.NewValues["ItemName"].ToString();
            item.CategoryId = Int32.Parse(e.NewValues["CategoryId"].ToString());
            item.ImageUrl = "You need to do something here...";

            demoEntities.SaveChanges();
            
            Response.Redirect("~/Product.aspx");
        }
        catch (Exception ex)
        {
            //ex.Message
        }
        finally
        {
            e.Cancel = true;
        }
    }
    protected void FormView1_ItemDeleted(object sender, FormViewDeletedEventArgs e)
    {
        
    }
    protected void FormView1_ItemDeleting(object sender, FormViewDeleteEventArgs e)
    {
        
        int deletingItemId = (int) e.Keys[0];

        var deletingItem = (from item in demoEntities.Items
                           where item.ItemId == deletingItemId
                           select item).SingleOrDefault<Item>();                
        try
        {
            demoEntities.DeleteObject(deletingItem);
            demoEntities.SaveChanges();
            
            //delete succeed
            Response.Redirect("~/Product.aspx");
        }
        catch (Exception ex)
        {
            // delete failed
        }
        finally
        {
            e.Cancel = true;
        }        
    }
}