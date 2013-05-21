<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label>Zip code</label>
    <asp:TextBox ID="txtzipCode" runat="server" />
   <%-- <label>City</label>
    <asp:TextBox ID="txtCity" runat="server" />
    <label>State</label>
    <asp:TextBox ID="txtState" runat="server" />
    <label>Country</label>
    <asp:TextBox ID="txtCountry" runat="server" />--%>
    <br />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="button1_Click"/>
    </div>
    </form>
</body>
</html>
