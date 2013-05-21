<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ OutputCache SqlDependency="mydb:tb_tasklist;mydb:MyPriority" Duration="3600" VaryByParam="none" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>        
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AppConnectionString1 %>"
        ProviderName="System.Data.SqlClient" SelectCommand="select * from tb_tasklist"
        ></asp:SqlDataSource>--%>
<%--        <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="mydbContextDataContext"
        TableName="tb_tasklists">
        </asp:LinqDataSource>
        
--%>        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="LinqDataSource1" DataTextField="Priority"
            DataValueField="Priority">
        </asp:DropDownList>
       <%-- <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:AppConnectionString1 %>" SelectCommand="SELECT [Priority] FROM [MyPriority]"
        ></asp:SqlDataSource>   --%>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="mydbContextDataContext" Select="new (Priority)" 
            TableName="MyPriorities">
        </asp:LinqDataSource>
        </div>
    </form>
</body>
</html>
