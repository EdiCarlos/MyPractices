<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ OutputCache Duration="20" VaryByParam="*" SqlDependency="CommandNotification" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <% Response.Write(DateTime.Now); %>
    <asp:SqlDataSource id="source" runat="server" ConnectionString="<%$ ConnectionStrings:NW %>" 
    SelectCommand="select empid, empname, empdob from temp1">
    </asp:SqlDataSource>
    
    <asp:DataGrid ID="grid" runat="server" DataSourceID="source"></asp:DataGrid>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:NW %>" 
            ProviderName="<%$ ConnectionStrings:NW.ProviderName %>" 
            SelectCommand="SELECT [Customer ID] AS Customer_ID, [Customer Name] AS Customer_Name, [City] FROM [Customer]">
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
