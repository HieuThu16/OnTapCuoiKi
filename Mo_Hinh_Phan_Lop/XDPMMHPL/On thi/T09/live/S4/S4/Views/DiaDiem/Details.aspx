<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<S4.Models.DiaDiem>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

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
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
