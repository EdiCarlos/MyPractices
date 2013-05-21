<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="error" culture="auto" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">

    <h2 class="header">
        <span class="title_header"><%= Resources.Common.Error %></span>
        <span class="clear"></span>
    </h2>
    <fieldset class="inner_color">
        <asp:label ID="lblText" runat="server" meta:resourcekey="lblTextResource1" />
        <asp:hyperlink ID="hlAdmin" runat="server" NavigateUrl="contact.aspx" meta:resourcekey="hlAdminResource1" />
    </fieldset>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebar" Runat="Server">
</asp:Content>

