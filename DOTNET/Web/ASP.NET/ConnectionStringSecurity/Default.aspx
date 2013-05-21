<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [Credit Authorization Number] AS Credit_Authorization_Number, [Customer Credit ID] AS Customer_Credit_ID, [Amount] FROM [Credit]">
        </asp:SqlDataSource>
        <label>Username</label>
        <asp:TextBox ID="user" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="*" ControlToValidate="user" ValidationGroup="loginValidate">
            </asp:RequiredFieldValidator>
            
        <br />
        <label>User Passwrord</label>
        <asp:TextBox ID="pass" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="*" ControlToValidate="user" ValidationGroup="loginValidate">
            </asp:RequiredFieldValidator>
            <br />
        <asp:Button ID="button1" runat="server" Text="Login" OnClick="button1_validate" />
    </div>
    </form>
</body>
</html>
