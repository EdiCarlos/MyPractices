<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link rel="Stylesheet" href="StyleSheet.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: auto; height: 750px;">
    <div style="width: auto; height: 150px;">
    <div style="float:left; width: auto; height: 150; background-color:Red;">
   <h1 style="text-align:center;">
    This is my forum
    </h1>
    </div>
    <div style="float:right; width:auto;">
    <asp:Login ID="Login1" runat="server" Width="313px"  
            OnAuthenticate="Authenticate_login1" Orientation="Vertical" 
            CssClass="LeftAlign">
    </asp:Login>
   </div>
   </div>
    <div style="width: 150px; height: 500; text-align:left;">
    <p>
    <ul style="list-style:none;">
    <li>
    <a href="Home.aspx">Home</a>
    </li>
    <li>
  <a href="secure/Page1.aspx">Page 1</a>
    
    </li>
    <li>
  <a href="secure/Page2.aspx">Page 2</a>
    
    </li>
    <li>
    <a href="AboutUs.aspx">About Us</a>
    
    </li>
    <li>
    </li>
    
    </ul>
    </p>
    </div>
    </div>
    
    </form>
</body>
</html>
