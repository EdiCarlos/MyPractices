<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Administration Information" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="info.aspx.cs" Inherits="admin_info" culture="auto" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" Runat="Server">   
    <h4 class="header">
        <span class="title_header"><%= Resources.Common.Information %></span>
        <span class="clear"></span>
        <span class="smaller"><asp:Label ID="lblReport" runat="server" /></span>
    </h4>
    <div style="text-align:left;" class="header">
        <asp:literal runat="server" ID="litDescription" meta:resourcekey="litDescriptionResource1" />
    </div>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>Index</h2>
        <ul class="bold">
            <li><a href="#setup"><asp:literal runat="server" Text="Initial Setup" 
                    ID="litInitSetup" meta:resourcekey="litInitSetupResource1" /></a></li>
            <li><a href="#permissions"><%= Resources.Common.Permissions %></a></li>
            <li><a href="#groups"><%= Resources.Common.Groups %></a></li>
            <li><a href="#users"><%= Resources.Common.Users %></a></li>
            <li><a href="#settings"><%= Resources.Common.Settings %></a></li>
            <li><a href="#info"><%= Resources.Common.Information %></a></li>
            <li><a href="#stats"><%= Resources.Common.Statistics %></a></li>
        </ul>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>
            <a href="#home" class="right smaller"><%= Resources.Common.BackToTop %></a>
            <a id="setup"></a>
            <asp:literal runat="server" Text="Initial Setup" ID="litInitSetup2" 
                meta:resourcekey="litInitSetup2Resource1" />
        </h2>
        <asp:Literal runat="server" ID="litText1" meta:resourcekey="litText1Resource1" />
        <br />
        <a href="#home" class="bold"><%= Resources.Common.BackToTop %></a>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>
            <a href="#home" class="right smaller"><%= Resources.Common.BackToTop %></a>
            <a id="permissions"></a>
            <%= Resources.Common.Permissions %>
        </h2>
        <br />
        <div>
            <asp:Literal runat="server" ID="litText2" meta:resourcekey="litText2Resource1" />
        </div>
        <br />
        <a href="#home" class="bold"><%= Resources.Common.BackToTop %></a>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>
            <a href="#home" class="right smaller"><%= Resources.Common.BackToTop %></a>
            <a id="groups"></a>
            <%= Resources.Common.Groups %>
        </h2>
        <div>
            <asp:Literal runat="server" ID="litText3" meta:resourcekey="litText3Resource1" />
        </div>
        <br />
        <a href="#home" class="bold"><%= Resources.Common.BackToTop %></a>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>
            <a href="#home" class="right smaller"><%= Resources.Common.BackToTop %></a>
            <a id="users"></a>
            <%= Resources.Common.Users %>
        </h2>
        <div>
            <asp:Literal runat="server" ID="litText4" meta:resourcekey="litText4Resource1" />
        </div>
        <br />
        <a href="#home" class="bold"><%= Resources.Common.BackToTop %></a>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>
            <a href="#home" class="right smaller"><%= Resources.Common.BackToTop %></a>
            <a id="settings"></a>
            <%= Resources.Common.Settings %>
        </h2>
        <div class="faq_body">
            <asp:Literal runat="server" ID="litText5" meta:resourcekey="litText5Resource1" />
        </div>
        <br />
        <a href="#home" class="bold"><%= Resources.Common.BackToTop %></a>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>
            <a href="#home" class="right smaller"><%= Resources.Common.BackToTop %></a>
            <a id="info"></a>
            <%= Resources.Common.Information %>
        </h2>
        <div>
            <asp:Literal runat="server" ID="litText6" meta:resourcekey="litText6Resource1" />
        </div>
        <br />
        <a href="#home" class="bold"><%= Resources.Common.BackToTop %></a>
    </fieldset>
    <div class="divider"></div>
    <fieldset class="inner_color">
        <h2>
            <a href="#home" class="right smaller"><%= Resources.Common.BackToTop %></a>
            <a id="stats"></a>
            <%= Resources.Common.Statistics %>
        </h2>
        <div>
            <asp:Literal runat="server" ID="litText7" meta:resourcekey="litText7Resource1" />
        </div>
        <br />
        <a href="#home" class="bold"><%= Resources.Common.BackToTop %></a>
    </fieldset>
</asp:Content>

