<%@ page language="C#" autoeventwireup="true" inherits="_Default, App_Web_255dbdcl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
    //<[CDATA[
        function showValue() {
            var proxy = new SimpleService2.IService2();
            alert(proxy);
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
            <asp:ServiceReference Path="~/Service2.svc" />
        </Services>
    </asp:ScriptManager>
    </form>
</body>
</html>
