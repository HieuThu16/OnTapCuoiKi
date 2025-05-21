<%@ Page Language="C#"  %>

<%@ Import Namespace="System" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.OleDb" %>

<script language="C#" runat="server">

   private void Page_Load(object sender, EventArgs e)
	{
		//page load coding goes here
       
	}

    private void btnComments_Click(object sender, EventArgs e)
    {
        LoadComments();
    }

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

                Repeater1.DataSource = ds;
                Repeater1.DataBind();
                
            }	
    }

</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Chapter 2: Inline coding sample in ASP.NET</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnComments" runat="server" Text="View All Comments" OnClick="btnComments_Click" />        
         <h1>
        Guestbook Entries</h1>        
       <asp:Repeater id="rptComments" runat="server">
											<ItemTemplate>
											<font face="Verdana" size="1">
													<strong>Name:&nbsp;</strong><%# Eval("FullName")%>
													<br>
													<strong>Email:&nbsp;</strong><%# Eval("EmailID")%>
													<br>
													<strong>Website:&nbsp;</strong><%# Eval("Website")%>
													<br>
													<strong>Dated&nbsp;</strong><%# Eval("EntryDate")%>
													<br>
													<strong>Comments:&nbsp;</strong><%# Eval("Comments")%>							
												</FONT>
											</ItemTemplate>
											<SeparatorTemplate>
												<p></p>												
												<p></p>
											</SeparatorTemplate>
										</asp:Repeater>
        &nbsp;</p>
            <p>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                    <%# Eval("FullName")%> : <%# Eval("Comments")%>
                    </ItemTemplate>
                    <SeparatorTemplate>
                    <br />
                    </SeparatorTemplate>
                </asp:Repeater>
            </p>
        </div>
    </form>
</body>
</html>
