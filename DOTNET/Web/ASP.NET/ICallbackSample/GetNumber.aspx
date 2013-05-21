<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetNumber.aspx.cs" Inherits="GetNumber" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <title></title>
    <script type="text/javascript">
        function GetNumber() {
            UseCallback();
        }
        function GetRandomNumber(TextBox1, context) {
            //            document.forms[0].TextBox1.value = TextBox1;
            $("#<%=TextBox1.ClientID %>").val(TextBox1);
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input ID="button1" type="button" runat="server" value="Get Number" onclick="GetNumber()" />
    <asp:TextBox ID="TextBox1" runat="server" />
    </div>
    </form>
</body>
</html>
