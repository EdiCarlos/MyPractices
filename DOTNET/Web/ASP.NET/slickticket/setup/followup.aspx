<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/setup/setup.master" AutoEventWireup="true" CodeFile="followup.aspx.cs" Inherits="setup_followup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="container">
        <h2>Almost Done...</h2>
        You have gotten through most of the grunt work, not just a few more things before you can continue:<br />
        <ul>
            <li>Fill out your <a href="../profile.aspx">profile</a>, you won't be able to navigate anywhere without it filled out, you will automatically be made an admin.</li>
            <li>
                Go to the <a href="../admin/settings.aspx">settings page</a>, click on 'Settings' and fill out everything there to avoid errors (domain controller is only necessary if you want to enable auto-suggest for AD Groups).
                <ul>
                    <li>If you want to enable AD Group Auto-suggest, go to the <a href="../admin/permissions.aspx">permissions page</a>, and click on 'Refresh AD' - this often needs to be done from the server itself.</li>
                </ul>
            </li>
        </ul>
        Now you are ready to go.  I recommend reading the entire <a href="../admin/info.aspx">admin information page</a> as well as the
        <a href="../help.aspx">faq</a> as it explains the permissions system as well as many other things about the system.
        <br /><br />
        Also, be sure to set up your <a href="../admin/groups.aspx">groups</a> right away and set some AD Groups on your 
        <a href="../admin/permissions.aspx">permissions page</a>
        - users can't fill out their profiles if they do not have permissions enough to join groups!
        <br /><br />
        <div class="error">IMPORTANT</div>    
        Once you are ready to deploy, you should delete or move this directory somewhere where it can't be accessed for security reasons.
    </div>
    
</asp:Content>

