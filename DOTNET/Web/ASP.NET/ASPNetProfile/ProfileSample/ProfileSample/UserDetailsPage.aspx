<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDetailsPage.aspx.cs" Inherits="ProfileSample.UserDetailsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label>First Name</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    <br />
        <label>First Name</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
        <label>Email Address</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>    
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnClearSession" runat="server" OnClick="btnClear_Click" Text="Clear" />
    </div>
    </form>
</body>
</html>
