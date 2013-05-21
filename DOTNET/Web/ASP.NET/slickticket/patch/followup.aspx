<%@ Page Title="" Language="C#" MasterPageFile="~/patch/MasterPage.master" AutoEventWireup="true" CodeFile="followup.aspx.cs" Inherits="patch_followup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <h2>Patch Successful</h2>
        Now that you have updated your database, go grab the newest <a href="http://slickticket.codeplex.com/SourceControl/ListDownloadableCommits.aspx">commit</a> and you will now be running Slick-Ticket v2.0.
        <br /><br />
        Any errors that may have occured are visible now in the <a href="patch_Data/comment_conversion_log.txt">Comment Conversion Log</a>, fix anything that may have gotten screwed up manually.
        Also, there may be a few formatting mishaps with the conversion and your old comments, but that is growing pains, sorry (fix them manually too if you like).
        <br /><br />
        Thank you for your interest in <a href="http://slick-ticket.com">Slick-Ticket</a>!
        <br /><br />
        <div class="error">IMPORTANT</div>    
        Once you run this upgrade, you will still have to download v2.0! I would grab the <a href="http://slickticket.codeplex.com/SourceControl/ListDownloadableCommits.aspx">newest build</a>.
        Once you download the newest version, be sure to delete the <b>patch</b> folder, it is no longer of any use, you can also delete the <b>setup</b> folder and the <b>App_Code/settings.cs</b> file if you would like.
    </div>
</asp:Content>

