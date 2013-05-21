<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/setup/setup.master" AutoEventWireup="true" CodeFile="build_database.aspx.cs" Inherits="setup_build_database" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <div class="container">
                <h2>
                    <asp:HyperLink style="float:right;" ID="lnkNext" Visible="false" runat="server" NavigateUrl="active_directory.aspx" Text="next" />
                    Database Creation 
                    <asp:Label ID="lblDBCreation" CssClass="success" runat="server"> - finished</asp:Label>
                </h2>
                Before you click the following button you need to do two things:<br />
                &nbsp;- Make a blank database name <b>SlickTicket</b><br />
                &nbsp;- Go into your web.config file and edit the <b>SlickTicket</b> ConnectionString<br /><br />
                <div style="font-weight:bold;">
                    <div class="error">IMPORTANT</div> 
                    This must be run by an account with rights to read the <span style="font-weight:bold;">setup/setup_Data</span> folder.
                </div>
                <br />
                <asp:Button runat="server" ID="btnRunSQL" Text="Create Tables" 
                    onclick="btnRunSQL_Click" />
                 - only click one time
                 <asp:Panel ID="pnlOutput" runat="server">
                    <asp:Label ID="lblOutput" runat="server" />
                 </asp:Panel>
            </div>

</asp:Content>

