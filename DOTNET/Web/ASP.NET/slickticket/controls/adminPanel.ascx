<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="adminPanel.ascx.cs" Inherits="controls_adminPanel" %>


    <table class="by2">
        <tr>
            <td>
                <a class="big_button" ID="hlPermissions" runat="server" href="~/admin/permissions.aspx">
                    <img runat="server" style="float:left;" src="~/images/icons/lock.png" alt="" />
                    <span><%= Resources.Common.Permissions %></span>
                    <q class="base_text"><asp:literal runat="server" ID="litPermissions" meta:resourcekey="litPermissionsResource1" /></q>
                </a>
            </td>
            <td>
                <a class="big_button" ID="hlGroups" runat="server" href="~/admin/groups.aspx">
                    <img runat="server" style="float:left;" src="../images/icons/promotion.png" alt="" />
                    <span><%= Resources.Common.Groups %></span>
                    <q class="base_text"><asp:literal runat="server" ID="litGroups" meta:resourcekey="litGroupsResource1" /></q>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a class="big_button" ID="hlUsers" runat="server" href="~/admin/users.aspx">
                    <img runat="server" style="float:left;" src="../images/icons/users.png" alt="" />
                    <span><%= Resources.Common.Users %></span>
                    <q class="base_text"><asp:literal runat="server" ID="litUsers" meta:resourcekey="litUsersResource1" /></q>
                </a>
            </td>
            <td>
                <a class="big_button" ID="hlSettings" runat="server" href="~/admin/settings.aspx">
                    <img runat="server" style="float:left;" src="../images/icons/process.png" alt="" />
                    <span><%= Resources.Common.Settings %></span>
                    <q class="base_text"><asp:literal runat="server" ID="litSettings" meta:resourcekey="litSettingsResource1" /></q>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a class="big_button" ID="hlInfo" runat="server" href="~/admin/info.aspx">
                    <img runat="server" style="float:left;" src="../images/icons/info.png" alt="" />
                    <span><%= Resources.Common.Information %></span>
                    <q class="base_text"><asp:literal runat="server" ID="litInfo" meta:resourcekey="litInfoResource1" /></q>
                </a>
            </td>
            <td>
                <a class="big_button" ID="hlStats" runat="server" href="~/admin/stats.aspx">
                    <img runat="server" style="float:left;" src="../images/icons/chart.png" alt="" />
                    <span><%= Resources.Common.Statistics %></span>
                    <q class="base_text"><asp:literal runat="server" ID="litStats" meta:resourcekey="litStatsResource1" /></q>
                </a>
            </td>
        </tr>
    </table>