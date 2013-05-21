<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
    //<[CDATA[
        function showValue() {
          
        }
        //]]>
    </script>

</head>
<body>
    <input type="button" id="btnAjax" value="test" onclick="return showValue();" />
    <form id="form1" runat="server">
    <div>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat='server'>
        <Services>
            <asp:ServiceReference Path="~/Service.svc" />
        </Services>
    </asp:ScriptManager>
    </form>
</body>
</html>
