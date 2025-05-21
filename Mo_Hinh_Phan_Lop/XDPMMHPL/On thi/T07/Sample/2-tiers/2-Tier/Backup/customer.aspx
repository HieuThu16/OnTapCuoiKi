<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="OMS.WebTier.customer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Chapter 4: Tiered Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
   <tr>
     <td>
      Name
     </td>
     <td>
      <asp:TextBox ID="txtName" runat="server">
      </asp:TextBox>
     </td>     
   </tr>
   <tr>
    <td>
     Address
    </td>
    <td>
     <asp:TextBox ID="txtAddress" runat="server">
     </asp:TextBox>
    </td>
   </tr>
   <tr>
    <td>
     PhoneNo
    </td>
    <td>
     <asp:TextBox ID="txtPhoneNo" runat="server" >
     </asp:TextBox>
    </td>
   </tr>
   
    <tr>
    <td>
     Username:
    </td>
    <td>
     <asp:TextBox ID="txtUsername" runat="server" >
     </asp:TextBox>
    </td>
   </tr>
   
    <tr>
    <td>
     Email
    </td>
    <td>
     <asp:TextBox ID="txtEmail" runat="server" >
     </asp:TextBox>
    </td>
   </tr>
   
    <tr>
    <td>
     Password
    </td>
    <td>
     <asp:TextBox ID="txtPassword" runat="server" >
     </asp:TextBox>
    </td>
   </tr>
    </table>
     <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
     <asp:Button ID="btnUpdate" runat="server" Text="update" OnClick="btnUpdate_Click" />
    </div>
    </form>
</body>
</html>
