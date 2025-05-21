<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chapter2.CodeBehindStyle.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Chapter 2: Code-behind sample in ASP.NET</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnComments" runat="server" Text="View All Comments" OnClick="btnComments_Click" />
        <h1>
            Guestbook Entries</h1>
        &nbsp;
        <p>
            &nbsp;</p>
        <p>
            <asp:Repeater ID="rptComments" runat="server">
                <ItemTemplate>
                    <font face="Verdana" size="1"><strong>Name:&nbsp;</strong>
                        <%# Eval("FullName")%>
                        <br>
                        <strong>Email:&nbsp;</strong><%# Eval("EmailID")%>
                        <br>
                        <strong>Website:&nbsp;</strong><%# Eval("Website")%>
                        <br>
                        <strong>Dated&nbsp;</strong><%# Eval("EntryDate")%>
                        <br>
                        <strong>Comments:&nbsp;</strong><%# Eval("Comments")%>
                    </font>
                </ItemTemplate>
                <SeparatorTemplate>
                    <p>
                    </p>
                    <p>
                    </p>
                </SeparatorTemplate>
            </asp:Repeater>
            &nbsp;</p>
    </div>
    </form>
</body>
</html>
