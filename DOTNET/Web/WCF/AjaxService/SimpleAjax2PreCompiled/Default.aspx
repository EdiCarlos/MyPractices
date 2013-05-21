<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleAjax2._Default" %>

<%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
         <script type="text/javascript">
   //<![CDATA[
             function doWork() {
                 var proxy = new SimpleAjax2.ISService();
                 alert(proxy);
             }
             //]]>
   
   </script>    
</head>
<body onload="doWork()">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    <Services>
    <asp:ServiceReference Path="~/SService.svc" />
    </Services>
    </asp:ScriptManager>
    </form>
</body>
</html>
