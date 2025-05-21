using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveC2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            demoEntities enties = new demoEntities();
            Item result = (from i in enties.Items
                                 where i.Category.CategoryName == "Cat 2"
                                 select i).FirstOrDefault<Item>();
            Response.Write(result.ItemName);
        }
    }
}
