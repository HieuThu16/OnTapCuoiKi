<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="OMS._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Chapter 03: Order Management System</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>All Products:</b>
    <br />
    <br />
        <asp:Repeater ID="prodRepeater" runat="server">
        <ItemTemplate>
         <font face="Verdana" size="1"><strong>Product Code:&nbsp;</strong>
													<%# Eval("Code")%>
													<br>
													<strong>Name:&nbsp;</strong><%# Eval("Name")%>
													<br>
													<strong>Unit Price:&nbsp;</strong>$<%# Eval("UnitPrice")%>
													<br>
													<br />
													<hr />
																			
												</FONT>
        </ItemTemplate>
        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
