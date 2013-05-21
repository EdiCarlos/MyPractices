<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetServerDateTime.aspx.cs"
    Inherits="GetServerDateTime" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function startTimer() {
            var timer = $find("<%=Timer1.ClientID %>");
            //            timer._startTimer();
        }
        function stopTimer() {
            var timer = $find("<%=Timer1.ClientID %>");
//            timer._stopTimer();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
         <Scripts>
         <asp:ScriptReference Name="MicrosoftAjaxCore.js" />
         <asp:ScriptReference Name="MicrosoftAjaxComponentModel.js" />
         <asp:ScriptReference Name="MicrosoftAjaxSerialization.js" />
         <asp:ScriptReference Name="MicrosoftAjaxNetwork.js" />
         </Scripts>
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Interval="500" >
        </asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
        <ContentTemplate>
            <asp:Label ID="lblDateTime" runat="server"></asp:Label>
        </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Button ID="btnStart" runat="server" Text="Start" OnClientClick="startTimer();"/>
        <asp:Button ID="btnStop" runat="server" Text="Stop" OnClientClick="stopTimer();"/>
    </div>

    </form>
</body>
</html>
