﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
        AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
        DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" 
       >
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
            <asp:BoundField DataField="username" HeaderText="username" 
                SortExpression="username" />
            <asp:BoundField DataField="userpass" HeaderText="userpass" 
                SortExpression="userpass" />
            <asp:BoundField DataField="useremail" HeaderText="useremail" 
                SortExpression="useremail" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#CCCCCC" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" 
        DeleteCommand="delete table usertable where id = @id " 
        InsertCommand="insert into usertable values(@id, @username, @userpass, @useremail);" 
        SelectCommand="SELECT id, username, userpass, useremail FROM usertable" 
        UpdateCommand="update usertable set username = @param1, userpass = @param2, useremail = @param3 where id = @idparam">
        <DeleteParameters>
            <asp:Parameter Name="id" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="param1" />
            <asp:Parameter Name="param2" />
            <asp:Parameter Name="param3" />
            <asp:Parameter Name="idparam" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="id" />
            <asp:Parameter Name="username" />
            <asp:Parameter Name="userpass" />
            <asp:Parameter Name="useremail" />
        </InsertParameters>
    </asp:SqlDataSource>
    <div>
    
    </div>
    </form>
</body>
</html>
