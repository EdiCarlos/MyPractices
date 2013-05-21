<%@ Page Title="" Language="C#" MasterPageFile="~/patch/MasterPage.master" AutoEventWireup="true" CodeFile="update_dbml_file.aspx.cs" Inherits="patch_update_dbml_file" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <div class="container">
                <h2>
                    <asp:HyperLink style="float:right;" ID="lnkNext" Visible="false" runat="server" NavigateUrl="convert_comments.aspx" Text="next" />
                    .dbml Update
                    <asp:Label ID="lblFinished" CssClass="success" runat="server"> - finished</asp:Label>
                </h2>
                This step is very important, and it has to be done manually since you can not write to the <b>App_Code</b> folder from within a program.<br />
                &nbsp;- Copy the 3 files from the <b>patch/patch_Data/App_Code</b> folder.<br />
                &nbsp;- Paste them into the <b>App_Code</b> folder in the root of your program; you will have to overwrite the existing files.
                <br /><br />
                <div style="font-weight:bold;">
                    <div class="error">IMPORTANT</div> 
                    Make sure this is done before you click on the button
                </div>
                <br />
                <asp:Button runat="server" ID="btnUpdate" Text="Files are Updated" 
                    onclick="btnUpdate_Click" />
                 - only click one time
                 <asp:Panel ID="pnlOutput" runat="server">
                    <asp:Label ID="lblOutput" runat="server" />
                 </asp:Panel>
            </div>

</asp:Content>

