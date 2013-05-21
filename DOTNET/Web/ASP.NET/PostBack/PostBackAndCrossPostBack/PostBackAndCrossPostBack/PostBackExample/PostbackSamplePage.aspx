<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostbackSamplePage.aspx.cs" Inherits="PostBackAndCrossPostBack.PostBackExample.PostbackSamplePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="postBackDropDown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="postBackDropDown_SelectedIndexChanged">
                <asp:ListItem Text="Select" />
                <asp:ListItem Text="Red" />
                <asp:ListItem Text="Green" />
                <asp:ListItem Text="Yellow" />
            </asp:DropDownList>
        <br />
            <asp:Panel ID="colorPanel" runat="server" Width="100" Height="100" />
        </div>
    </form>
</body>
</html>
