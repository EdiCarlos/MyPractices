<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UseOfData.aspx.cs" Inherits="UseOfData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:AdventureWorksConnectionString %>" 
            SelectCommand="SELECT AddressID, AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, rowguid, ModifiedDate FROM Person.Address WHERE (AddressID = @addressid)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="addressid" 
                    QueryStringField="AddressId" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="AddressID" DataSourceID="LinqDataSource1">
        <Columns>
            <asp:BoundField DataField="AddressID" HeaderText="AddressID" 
                InsertVisible="False" ReadOnly="True" SortExpression="AddressID" />
            <asp:BoundField DataField="AddressLine1" HeaderText="AddressLine1" 
                SortExpression="AddressLine1" />
            <asp:BoundField DataField="AddressLine2" HeaderText="AddressLine2" 
                SortExpression="AddressLine2" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="StateProvinceID" HeaderText="StateProvinceID" 
                SortExpression="StateProvinceID" />
            <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" 
                SortExpression="PostalCode" />
            <asp:BoundField DataField="rowguid" HeaderText="rowguid" 
                SortExpression="rowguid" />
            <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" 
                SortExpression="ModifiedDate" />
        </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="DBClassDataContext" TableName="Addresses" 
        Where="AddressID == @AddressId" EnableDelete="True">
        
        <WhereParameters>
            <asp:QueryStringParameter Name="AddressID" QueryStringField="AddressId" 
                Type="Int32" />
        </WhereParameters>
    </asp:LinqDataSource>
    </form>
</body>
</html>
