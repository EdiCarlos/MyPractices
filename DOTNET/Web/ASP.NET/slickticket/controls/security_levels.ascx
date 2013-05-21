<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="security_levels.ascx.cs"  Inherits="admin_controls_security_levels" %>

    
    <div class="small_container border_color">
        <fieldset style="text-align:left;" class="inner_color">
            <h3>
                <span class="title_header"><asp:literal runat="server" ID="litAccessLevels" meta:resourcekey="litAccessLevelsResource1" /></span>
                <a class="smaller" href="settings.aspx"><%= Resources.Common.Edit %></a>
            </h3>
            <br />
            <asp:Label ID="lblSecurityLevelExplanations" runat="server" CssClass="smaller"  />
        </fieldset>
    </div>
    