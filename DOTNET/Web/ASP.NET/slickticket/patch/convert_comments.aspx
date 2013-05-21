<%@ Page Title="" Language="C#" MasterPageFile="~/patch/MasterPage.master" AutoEventWireup="true" CodeFile="convert_comments.aspx.cs" Inherits="patch_convert_comments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div class="container">
                <h2>
                    <asp:HyperLink style="float:right;" ID="lnkNext" Visible="false" runat="server" NavigateUrl="followup.aspx" Text="next" />
                    Comment Update
                    <asp:Label ID="lblFinished" CssClass="success" runat="server"> - finished</asp:Label>
                </h2>
                Almost done, now we just have to convert the comments and tickets from the old crappy version, to the new clean version; 
                you won't actually see any difference, but it will be much better from a programming standpoint.
                <br /><br />
                Due to my poor implementation in v1.0, this is far from a perfect conversion.  
                All errors will be logged, but if Group/Sub-Group names, Priorities or Statuses have been changed, there may be some lost parts of the data (nothing catastrophic).
                I highly suggest running a backup before running this... just in case.
                <br /><br />
               <asp:Button runat="server" ID="btnUpdate" Text="Fix my Comments" onclick="btnUpdate_Click" />
                 - only click one time
                 <asp:Panel ID="pnlOutput" runat="server">
                    <asp:Label ID="lblOutput" runat="server" />
                 </asp:Panel>
            </div>
</asp:Content>

