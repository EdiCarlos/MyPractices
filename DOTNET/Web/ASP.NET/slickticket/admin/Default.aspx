<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Administration Dashboard" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" Runat="Server">
    <fieldset class="inner_color">
        <ctrl:AdminPanel ID="admPanel" runat="server" />
    </fieldset>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="adminSidebar" Runat="Server">
</asp:Content>

