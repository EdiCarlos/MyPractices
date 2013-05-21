<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnableThemeSamplePage.aspx.cs" Inherits="ControlSample.EnableThemeSamplePage" Theme="Red" %>
<%@ Register TagName="RedButton" TagPrefix="button" Src="~/Controls/EnableThemeControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <button:RedButton id="redButton1"  runat='server' />
    </div>
    </form>
</body>
</html>
