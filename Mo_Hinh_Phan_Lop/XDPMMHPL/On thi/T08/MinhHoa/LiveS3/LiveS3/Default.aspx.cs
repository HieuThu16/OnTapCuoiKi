using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveS3
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DemoEntities entities = new DemoEntities();

            List<Item> items = (from i in entities.Items
                                where i.Category.CategoryName == "Cat 2"
                                select i).ToList<Item>();

            Label1.Text = items.ToString();
        }
    }
}
