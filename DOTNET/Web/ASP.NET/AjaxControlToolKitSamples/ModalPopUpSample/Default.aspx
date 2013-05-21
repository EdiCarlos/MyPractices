<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit, Version=3.5.51116.0, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"
    Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="file:///D:\MyPractices\DOTNET\C#\WEB\WebExamples\AjaxControlToolKitSamples\ModalPopUpSample\StyleSheet.css"
        rel="stylesheet" type="text/css" />

    <script src="file:///D:\MyPractices\DOTNET\C#\WEB\WebExamples\AjaxControlToolKitSamples\ModalPopUpSample\jquery-1.7.2.js"
        type="text/javascript">
    </script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script>
        function btn_OnScript(message) {
            $('#txt1').val($("#txtUserName1").val() + " " + $("#txtUserName").val());
        }                    
    </script>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="button1"
            CancelControlID="btnCancel" OkControlID="btnOk" DropShadow="true" BackgroundCssClass="modalBackground"
            PopupControlID="panelPopup" OnOkScript="btn_OnScript()">
        </asp:ModalPopupExtender>
        <asp:Button ID="button1" runat="server" Text="Open" />
        <asp:Panel ID="panelPopup" runat="server" Style="display: none; width: 200px; background-color: White;
            border-width: 2px; border-color: Black; border-style: solid; padding: 20px;">
            <asp:Label ID="lblUsername" runat="server" Text="UserName:" />
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <input id="txtUserName1" runat="server" />
            <input type="button" id="btnOk" runat="server" value="Ok" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </asp:Panel>
        <input type="text" id='txt1' value='' />
        <p id="paragraph">
        </p>
    </div>
    </form>
</body>
</html>
