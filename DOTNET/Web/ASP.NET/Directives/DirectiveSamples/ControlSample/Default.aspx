<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ControlSample._Default" %>
<%@ Register TagPrefix="login" TagName="LoginControl" Src="~/LoginUserControl.ascx" %>
<%@ Register TagPrefix="sampleLbl" TagName="SampleLabel" Src="~/SampleControl.ascx" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
</head>
<body>
<form id="form1" runat="server">
<%--<sampleLbl:SampleLabel runat="server" id="samplelbl" />
<login:LoginControl id="loginControl1" runat="server" />
--%>
<ul style="list-style-type:none;">
<li><a href="EnableThemeSamplePage.aspx"> EnableTheme Sample</a>
</li>
<li><a href="DebugSample.aspx"> Debug Sample</a>
</li>
<li></li>
</ul>
</form>
</body>
</html>
