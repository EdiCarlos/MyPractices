<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="~/LoginUserControl.ascx.cs" Inherits="ControlSample.LoginUserControl" %>
<asp:Panel ID="loginPanel" runat="server">
<asp:Label ID="lblUserName" runat="server" Text="User Name">
</asp:Label>
<asp:TextBox ID="txtUserName" runat="server">
</asp:TextBox>
<asp:Label ID="lblPassword" runat="server" Text="User Password">
</asp:Label>
<asp:TextBox ID="txtPassword" runat="server">
</asp:TextBox>
<asp:Button ID="btnLogin" runat="server"  Text="Login" />
</asp:Panel>