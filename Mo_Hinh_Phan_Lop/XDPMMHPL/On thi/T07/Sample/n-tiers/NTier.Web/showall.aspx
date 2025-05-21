<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showall.aspx.cs" Inherits="NTier.Web.showall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Namespace="ASPnetControls" Assembly="ASPnetPagerV2_8" TagPrefix="cc" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Chapter 4: 5 tier Sample</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="rptCustomers" runat="server" OnItemCommand="rptCustomers_ItemCommand">
    <HeaderTemplate>
     <table>
      <tr>
       <th width="100px">
        Name
       </th>
       <th width="200px">
        Address
       </th>
       <th width="100px">
        PhoneNumber
       </th>
       <th width="100px">
        Edit
       </th>
       <th width="100px">
        Delete
       </th>
      </tr>
     </table>
    </HeaderTemplate>
     <ItemTemplate>
     <table>
     
      <tr>
      <td width="100px">
      <%#Eval("Name")%>
      </td>
      <td width="200px">
      <%#Eval("Address")%>
      </td>
      <td width="100px">
      <%#Eval("PhoneNo")%>
      </td>
      <td align="right" width="100px">
       <asp:HyperLink ID="btnEdit" runat="server" Text="Edit" NavigateUrl='<%# "~/customer.aspx?cid=" + Eval("ID")%>' />
      </td>
      <td align="right" width="100px">
       <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandArgument='<%# Eval("ID")%>' CommandName="Delete"/>
      </td>
      <td>
      </td>
      </tr>
      </table>
     </ItemTemplate>
    </asp:Repeater>
    
    <cc:PagerV2_8 ID="pager1" runat="server"  OnCommand="pager_Command" GenerateGoToSection="true"
                 />
                
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
