<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="sm1" AjaxFrameworkMode="Explicit" runat="server" EnableCdn="true" >
        <Scripts>
            <asp:ScriptReference Name="MicrosoftAjaxCore.js" />
            <asp:ScriptReference Name="MicrosoftAjaxComponentModel.js" />
            <asp:ScriptReference Name="MicrosoftAjaxSerialization.js" />
            <asp:ScriptReference Name="MicrosoftAjaxNetwork.js" />
        </Scripts>
    </asp:ScriptManager>
    <div>
        <asp:Button ID="text1" runat="server" Text="this is text1" />
        <script type="text/javascript">
            alert($('#text1').val());
        </script>
    </div>
    </form>
</body>
</html>
