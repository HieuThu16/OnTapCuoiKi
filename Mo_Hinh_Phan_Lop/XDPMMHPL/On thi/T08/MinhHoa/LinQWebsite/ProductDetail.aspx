<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="DemoModel.DemoEntities"
        EntityTypeName="" TableName="Categories">
    </asp:LinqDataSource>
    <asp:FormView ID="FormView1" runat="server" DataKeyNames="ItemId" DataSourceID="LinqDataSource1"
        OnItemDeleted="FormView1_ItemDeleted" OnItemInserted="FormView1_ItemInserted"
        OnItemInserting="FormView1_ItemInserting" 
        OnItemUpdating="FormView1_ItemUpdating" onitemdeleting="FormView1_ItemDeleting">
        <EditItemTemplate>
            <asp:Table ID="ItemTable" runat="server" GridLines="None">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        ItemName:
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ItemName") %>' />
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("ImageUrl") %>' Width="300" />
                        <br />
                        Image:
                        <asp:FileUpload ID="FileUploadItemImage" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        Category:
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="LinqDataSource2"
                            DataTextField="CategoryName" DataValueField="CategoryId" SelectedValue='<%# Bind("CategoryId") %>'
                            AppendDataBoundItems="True">
                            <asp:ListItem Value="">Please select a category</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                        More info input
                        <br />
                        More info input
                        <br />
                    </asp:TableCell></asp:TableRow></asp:Table><br /><asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False"
                CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            <asp:Label ID="LabelInsertError" runat="server" Text="" ForeColor="Red"></asp:Label><br /><asp:Table ID="ItemTable" runat="server" GridLines="None">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        ItemName:
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ItemName") %>' />
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        Image:
                        <asp:FileUpload ID="FileUploadItemImage" runat="server" />
                    </asp:TableCell><asp:TableCell>
                        Category:
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="LinqDataSource2"
                            DataTextField="CategoryName" DataValueField="CategoryId" SelectedValue='<%# Bind("CategoryId") %>'
                            AppendDataBoundItems="True">
                            <asp:ListItem Value="">Please select a category</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                        More info input
                        <br />
                        More info input
                        <br />
                    </asp:TableCell></asp:TableRow></asp:Table><br /><asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False"
                CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            <asp:Table ID="ItemTable" runat="server" GridLines="None">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ItemName") %>' />
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("ImageUrl") %>' Width="300" />
                    </asp:TableCell><asp:TableCell>
                        Category:
                        <asp:Label ID="LabelCategoryName" runat="server" Text='<%# Bind("Category.Categoryname") %>'></asp:Label>
                        <asp:HiddenField ID="HiddenFieldCategoryId" runat="server" Value='<%# Bind("CategoryId")%>' />
                        <br />
                        More info
                        <br />
                        More info
                        <br />
                    </asp:TableCell></asp:TableRow></asp:Table><br /><asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit"
                Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete"
                Text="Delete" OnClientClick="return confirm('Are you sure?');" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New"
                Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="DemoModel.DemoEntities" EntityTypeName=""
        TableName="Items" Where="ItemId == @ItemId"><WhereParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="ItemId" QueryStringField="itemId"
                Type="Int32" />
        </WhereParameters>
    </asp:LinqDataSource>
</asp:Content>
