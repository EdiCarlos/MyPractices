<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SampleControl2.ascx.cs" Inherits="ResourcesSample.Modules.SampleControl2" %>

<asp:Panel ID="Panel1" runat="server">
<asp:Label ID="lusername" runat="server" Text="<%$ Resources:Resource, lblUsername %>">
</asp:Label>
<br />
<asp:Label ID="Label1" runat="server" Text="<%$ Resources:Resource, lblPassword %>">
</asp:Label>

<br />
<asp:Label ID="lblResource" runat="server" Text="<%$ Resources:Resource, lblPassword %>">

</asp:Label>
</asp:Panel>