<%@ Page Language="C#" AutoEventWireup="true" CodeFileBaseClass="MyPageBase.PageBase" CodeFile="~/Default.aspx.cs" Inherits="PageAttributes.Default" %>
<%@ Assembly Name="MyPageBase" %>
<%@ Import Namespace="MyPageBase" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul style="list-style-type:none;">
    <li><a href="AspCompactSample.aspx">AspCompact Sample</a></li>
    <li><a href="AsyncSample.aspx">Async Sample</a></li>
    <li><a href="AsyncTimeOutSample.aspx">AsyncTimeout Sample</a></li>
    <li><a href="AutoEventWireUpSample.aspx">AutoEventWireUp Sample</a></li>
    <li><a href="EnableViewStateSamples.aspx">EnableViewState Sample</a></li>
    <li><a href="CompilationModeSample.aspx">CompilatioMode Sample</a></li>
    </ul>
    </div>
    </form>
</body>
</html>
