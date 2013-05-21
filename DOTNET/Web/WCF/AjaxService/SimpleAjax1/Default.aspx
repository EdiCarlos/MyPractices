<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleAjax1.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script type='text/javascript'>
        //<![CDATA[
        function ShowWork() {
            var proxy = new SimpleAjax1.IService1();
            
        }
    //]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
   <Services>
   <asp:ServiceReference Path="~/Service1.svc" />
   </Services>
    </asp:ScriptManager>
    </form>
</body>
</html>
