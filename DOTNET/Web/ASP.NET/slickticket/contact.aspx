<%--
Slick-Ticket v1.0 - 2008
http://slick-ticket.com
Developed by Stan Naspinski - stan@naspinski.net
http://naspinski.net
--%>
<%@ Page Title="Contact Administrator" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" culture="auto" meta:resourcekey="PageResource1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <fieldset class="inner_color">
        <asp:UpdatePanel ID="up" runat="server">
            <ContentTemplate>
                <asp:Panel ID="pnlInput" runat="server" >
                    <asp:Label ID="lblInReport" runat="server" />
                    <h3>
                        <asp:Label ID="lblQuestion" runat="server" cssclass="title_header" meta:resourcekey="lblQuestionResource1" />
                        <asp:RequiredFieldValidator ID="rfvSubject" runat="server" ControlToValidate="txtSubject" meta:resourcekey="rfvSubjectResource1" />
                    </h3>
                    <h2><asp:TextBox ID="txtSubject" runat="server" CssClass="full_window" /></h2>
                    <h3>
                        <asp:Label ID="lblDetails" runat="server" cssclass="title_header" meta:resourcekey="lblDetailsResource1" />
                        <asp:RequiredFieldValidator ID="rfvBody" runat="server" ControlToValidate="txtBody" meta:resourcekey="rfvBodyResource1" />
                    </h3>
                    <asp:TextBox ID="txtBody" runat="server" CssClass="full_window" TextMode="MultiLine" Rows="5" />
                    <br />
                    <div style="text-align:center;">
                        <asp:Button ID="btnSend" runat="server" CssClass="button" onclick="btnSend_Click" meta:resourcekey="btnSendResource1" />
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlOutput" runat="server" Visible="False" >
                    <h2><asp:Label ID="lblReport" runat="server" /></h2>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </fieldset>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="sidebar" Runat="Server">
</asp:Content>

