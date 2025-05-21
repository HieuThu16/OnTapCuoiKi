<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="DemoModel.DemoEntities" EntityTypeName="" OrderBy="ItemName" 
        Select="new (ItemId, ItemName, ImageUrl, Category, CategoryId)" 
        TableName="Items">
    </asp:LinqDataSource>
    <asp:ListView ID="ListView1" runat="server" GroupItemCount="3" 
        DataSourceID="LinqDataSource1">
        <LayoutTemplate>
            <table id="Table7" runat="server">
                <tr id="Tr1" runat="server">
                    <td id="Td1" runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="0" style="" cellpadding="30"
                            cellspacing="10">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr id="Tr2" runat="server">
                    <td id="Td2" runat="server" style="">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server">
                </td>
            </tr>
        </GroupTemplate>
        <ItemTemplate>
            <td id="Td1" runat="server" style="">
                <asp:Table ID="ItemTable" runat="server" GridLines="None">
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# String.Format("ProductDetail.aspx?itemId={0}", Eval("ItemId")) %>'>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("ItemName")%>' />
                            </asp:HyperLink>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageUrl") %>' Width="50" />
                        </asp:TableCell>
                        <asp:TableCell>
                            Category:
                            <asp:Label ID="LabelCategory" runat="server" Text='<%# Eval("Category.CategoryName") %>' />
                            <br />
                            More info
                            <br />
                            More info
                            <br />
                        </asp:TableCell></asp:TableRow></asp:Table></td></ItemTemplate></asp:ListView><asp:DataPager 
        ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="3"><Fields><asp:NumericPagerField /></Fields></asp:DataPager><br /><br /><asp:TextBox 
        ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" 
        runat="server" onclick="Button1_Click" Text="Search" /></asp:Content>
