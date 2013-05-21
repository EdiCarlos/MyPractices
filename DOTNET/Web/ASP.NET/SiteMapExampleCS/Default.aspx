<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Title="Default Page" %>

<asp:Content ContentPlaceHolderID="head" ID="Content2" runat="server">
this is head
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="Content1" runat="server">
<label>
<asp:Literal ID="litPage3" runat="server" meta:resourceKey="PageName">
</asp:Literal>
</label>
</asp:Content>
