using System;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Chapter2.CodeBehindStyle
{
    public partial class Default : System.Web.UI.Page
    {        
      
        protected void btnComments_Click(object sender, EventArgs e)
        {
            LoadComments();
        }

        /// <summary>
        /// Load all comments from the Access DB
        /// </summary>
        private void LoadComments()
        {
            string AppPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string sCon = @"Provider=Microsoft.JET.OLEDB.4.0; Data Source=" + AppPath + "/App_Data/Guestbook.mdb";

            using (OleDbConnection cn = new OleDbConnection(sCon))
            {
                string sQuery = @"SELECT * FROM Guestbook order by EntryDate desc";
                OleDbCommand cmd = new OleDbCommand(sQuery, cn);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                cn.Open();
                da.Fill(ds);
                rptComments.DataSource = ds;
                rptComments.DataBind();
            }
        }

    }//end class
}//end namespace
