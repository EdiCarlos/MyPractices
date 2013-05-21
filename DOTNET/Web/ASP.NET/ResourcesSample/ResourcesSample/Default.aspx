<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ResourcesSample._Default" MasterPageFile="~/Master.Master" %>
<%@ Register Src="~/Modules/SampleControl1.ascx" TagName="Sample" TagPrefix="smp"%>
<%@ Register Src="~/Modules/SampleControl2.ascx" TagName="Sample2" TagPrefix="smp2" %>
<asp:Content id="mainContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
<asp:Panel ID="panel1" runat="server">
<asp:Label ID="lblSample1" runat="server" meta:resourcekey="lblSample1" />
 <smp:Sample id="smp1" runat="server" />
 <hr />
<smp2:Sample2 id="smp2" runat="server" />
</asp:Panel>
</asp:Content>
