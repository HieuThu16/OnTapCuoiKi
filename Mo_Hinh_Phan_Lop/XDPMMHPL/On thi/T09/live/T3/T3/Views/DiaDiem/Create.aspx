<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<T3.Models.DiaDiem>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>DiaDiem</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.MaDiaDiem) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.MaDiaDiem) %>
            <%: Html.ValidationMessageFor(model => model.MaDiaDiem) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TenDiaDiem) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TenDiaDiem) %>
            <%: Html.ValidationMessageFor(model => model.TenDiaDiem) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
    <%: Scripts.Render("~/bundles/jqueryval") %>
</asp:Content>
