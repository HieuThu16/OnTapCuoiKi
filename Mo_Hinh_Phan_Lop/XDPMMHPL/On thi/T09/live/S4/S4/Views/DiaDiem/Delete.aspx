<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<S4.Models.DiaDiem>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>DiaDiem</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.MaDiaDiem) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.MaDiaDiem) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.TenDiaDiem) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TenDiaDiem) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
