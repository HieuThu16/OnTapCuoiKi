<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<T3.Models.DiaDiem>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

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

        <%: Html.HiddenFor(model => model.Id) %>

        <p>
            <input type="submit" value="Save" />
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
