<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" culture="auto" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <fieldset class="inner_color">
        <h2>Navigation</h2>
        <table class="by2">
            <tr>
                <td>
                    <a class="big_button" href="new_ticket.aspx">
                        <img style="float:left;" src="images/icons/add_page.png" alt="" />
                        <span><%= Resources.Common.NewTicket %></span>
                        <q class="base_text">
                           <%-- <asp:Literal id="litNewTicket" runat="server"  meta:resourcekey="litNewTicketResource1"  />--%>
                           <asp:Literal ID="litmyticket" runat="server" meta:resourcekey="litmyticketResource1" />
                        </q>
                    </a>
                </td>
                <td>
                    <a class="big_button" href="ticket.aspx"><img style="float:left;" src="images/icons/search_page.png" alt="" />
                        <span><%= Resources.Common.ViewTicket %></span>
                        <q class="base_text">
                            <asp:Literal id="litViewTicket" runat="server"  meta:resourcekey="litViewTicketResource1"  />
                        </q>
                    </a>
                </td>
            </tr>
            <tr>
                <td>
                    <a class="big_button" href="my_issues.aspx">
                        <img style="float:left;" src="images/icons/folder_full.png" alt="" />
                        <span><%= Resources.Common.MyIssues %></span>
                        <q class="base_text">
                            <asp:Literal id="litMyIssues" runat="server" meta:resourcekey="litMyIssuesResource1" />
                        </q>
                    </a>
                </td>
                <td>
                    <a class="big_button" href="profile.aspx">
                        <img style="float:left;" src="images/icons/user.png" alt="" />
                        <span><%= Resources.Common.Profile %></span>
                        <q class="base_text">
                            <asp:Literal id="litProfile" runat="server" meta:resourcekey="litProfileResource1" />
                        </q>
                    </a>
                </td>
            </tr>
            <tr>
                <td>
                    <a class="big_button" href="search.aspx">
                        <img style="float:left;" src="images/icons/search.png" alt="" />
                        <span><%= Resources.Common.Dashboard %></span>
                        <q class="base_text">
                            <asp:Literal id="litSearch" runat="server" meta:resourcekey="litSearchResource1" />
                        </q>
                    </a>
                </td>
                <td>
                    <a class="big_button" href="help.aspx">
                        <img style="float:left;" src="images/icons/help.png" alt="" />
                        <span><%= Resources.Common.Help %></span>
                        <q class="base_text">
                            <asp:Literal id="litHelp" runat="server" meta:resourcekey="litHelpResource1" />
                        </q>
                    </a>
                </td>
            </tr>
            <tr>
                <td>
                    <a class="big_button" href="contact.aspx">
                        <img style="float:left;" src="images/icons/comment.png" alt="" />
                        <span><%= Resources.Common.Contact %></span>
                        <q class="base_text">
                            <asp:Literal id="LlitContact" runat="server" meta:resourcekey="LlitContactResource1" />
                        </q>
                    </a>
                </td>
                <td></td>
            </tr>
        </table>
    </fieldset>
    <div class="divider"></div>
    <asp:Panel ID="pnlAdmin" runat="server" Visible="False" >
        <fieldset class="inner_color">
            <h2><asp:Literal id="litAdmin" runat="server" meta:resourcekey="litAdminResource1" /></h2>
            <ctrl:AdminPanel ID="admPanel" runat="server" />
        </fieldset>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebar" Runat="Server">
</asp:Content>

