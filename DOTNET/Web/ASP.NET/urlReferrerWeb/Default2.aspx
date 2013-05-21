<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <% Response.Write(Request.UrlReferrer); %> 
    <%Response.Write(Request.Url); %>   
    <br />
    <%Response.Write(Request.QueryString["logoff"]); %>
    <% Response.Write(Request.AppRelativeCurrentExecutionFilePath); %>
    </div>
    </form>
</body>
</html>
