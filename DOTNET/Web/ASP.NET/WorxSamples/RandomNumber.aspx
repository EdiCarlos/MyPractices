<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RandomNumber.aspx.cs" Inherits="RandomNumber" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
    function GetNumber()
    {
    UseCallback();
    }
    function GetRandomNumberFromServer(text, context)
    {
    document.forms[0].TextBox1.value = text;
    }
    function ConvertArea(text, context)
    {
    document.forms[0].TextBox2.value = text;
    }
    function GetTemp()
    {
    var zipCode = document.forms[0].TextBox1.value;
    UseCallback(zipCode, "");
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <input id="Button1" type="button"
            value="button" onclick="GetTemp()" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2"
            runat="server" Text="Button" onclick="Button2_Click" />
        
      
    </div>
    </form>
</body>
</html>
