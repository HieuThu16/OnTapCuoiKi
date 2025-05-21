<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showall.aspx.cs" Inherits="DomainModel.UI.showall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Chapter 3: Domain Model 3 Layer</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="rptCustomers" runat="server" OnItemCommand="rptCustomers_ItemCommand">
    <HeaderTemplate>
     <table>
      <tr>
       <th>
        Name
       </th>
        Address
       <th>
       </th>
       <th>
        PhoneNumber
       </th>
       <th>
        Edit
       </th>
       <th>
        Delete
       </th>
      </tr>
     </table>
    </HeaderTemplate>
     <ItemTemplate>
     <table border="1">     
      <tr>
      <td>
      <%#Eval("Name")%>
      </td>
      <td>
      <%#Eval("Address")%>
      </td>
      <td>
      <%#Eval("PhoneNumber")%>
      </td>
      <td align="right">
       <asp:HyperLink ID="btnEdit" runat="server" Text="Edit" NavigateUrl='<%# "~/customer.aspx?cid=" + Eval("ID")%>' />
      </td>
      <td align="right">
       <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandArgument='<%# Eval("ID")%>' CommandName="Delete"/>
      </td>
      </tr>
      </table>
     </ItemTemplate>
    </asp:Repeater>
    <table>
     <tr>
      <td>
       <asp:Button ID="btnAdd" runat="server" Text="Add Customer" OnClick="btnAdd_Click"/>
      </td>
     </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
