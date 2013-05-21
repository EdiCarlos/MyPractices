<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="PostBackAndCrossPostBack.CrossPagePostBackExample.Page2"  %>
<%@ PreviousPageType VirtualPath="~/CrossPagePostBackExample/Page1.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Result:</label>
            <asp:TextBox ID="txtResult" runat="server" Enabled="false"></asp:TextBox>
        </div>
    </form>
</body>
</html>
