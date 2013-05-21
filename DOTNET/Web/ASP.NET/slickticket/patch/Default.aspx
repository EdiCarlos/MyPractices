<%@ Page Title="" Language="C#" MasterPageFile="~/patch/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="patch_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
    <div class="container">
        <h2>
            <a href="update_database.aspx" style="float:right;">next</a>
            Patch Instructions
        </h2>
        This wizard will walk you through the upgrade to the newer, more robust Slick-Ticket.  
        Due to some shortcuts I took with the original programming, some of the db structure and markup inside of the database (a no-no) is less than perfect.
        I had no idea this program would be as successful as it is, so I felt it was my duty to improve it to where I think it should be.
        <br /><br />
        <div class="error">IMPORTANT</div>    
        Only use this if you were previously running v1.05!<br />
        I highly suggest you make a database backup prior to this patch! 
        Also, if you need to revert to the last working copy prior to the patch, it is <a href="http://slickticket.codeplex.com/SourceControl/changeset/view/27685">build 27685</a>.
        <br /><br />
        If you have any problems, please visit <a href="http://slick-ticket.com">Slick-Ticket.com</a>.
        <br /><br />
        <a href="update_database.aspx">Start Patching</a>
    </div>
</asp:Content>

