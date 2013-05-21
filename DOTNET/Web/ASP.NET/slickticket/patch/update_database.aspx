<%@ Page Title="" Language="C#" MasterPageFile="~/patch/MasterPage.master" AutoEventWireup="true" CodeFile="update_database.aspx.cs" Inherits="patch_update_database" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <div class="container">
                <h2>
                    <asp:HyperLink style="float:right;" ID="lnkNext" Visible="false" runat="server" NavigateUrl="~/patch/update_dbml_file.aspx" Text="next" />
                    Database Update
                    <asp:Label ID="lblDBCreation" CssClass="success" runat="server"> - finished</asp:Label>
                </h2>
                This will add the necessary fields to the <b>comments</b> table and fill them with dummy values.
                <br /><br />
                <div style="font-weight:bold;">
                    <div class="error">IMPORTANT</div> 
                    This must be run by an account with read/write rights to the <span style="font-weight:bold;">patch/patch_Data</span> folder.
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

