<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="PostBackAndCrossPostBack.CrossPagePostBackExample.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculator</h1>
            <br />
            <label>Number 1: </label>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            <br />
            <label>Number 2: </label>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCalculatePostBack" runat="server" Text="Calculate" OnClick="btnCalculatePostBack_Click"/>
            <asp:Button ID="btnCalculateCrossPostBack" OnClick="btnCalculateCrossPostBack_Click" runat="server" Text="Calculate Cross Page" />
            <br />
            <label>Result:</label>
            <asp:TextBox ID="txtResult" runat="server" Enabled="false"></asp:TextBox>

        </div>
    </form>
</body>
</html>
