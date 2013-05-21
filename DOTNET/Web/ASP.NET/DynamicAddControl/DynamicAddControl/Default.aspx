<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DynamicAddControl.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <div>
        <asp:Button ID="btnAddTextBox" runat="server" OnClick="btnAddTextBox_Click" Text="Add Button" />

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:PlaceHolder ID="myPlaceHolder" runat="server"></asp:PlaceHolder>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAddTextBox" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        
    </div>
    </form>
</body>
</html>
