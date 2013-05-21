<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LoginStatus ID="loginStatus1" runat='server' 
            onloggingout="loginStatus1_LoggingOut" />
<div style="float:right;">
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
            <label>Please click login button to log yourself in. </label><a href='SignUp.aspx'>Sign Up</a>
            </AnonymousTemplate>
            <LoggedInTemplate>
            <asp:LoginName ID="loginname" runat="server" />
            </LoggedInTemplate>   
        </asp:LoginView>
        </div>
    </div>
    <div>
    <label>First Name</label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <label>Last Name</label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <label>Last Visited Page</label>
        <asp:TextBox ID="TextBox4" runat="server" Enabled="false"></asp:TextBox>
        <label>Age</label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <fieldset id="field1" title="Member">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Yes"  GroupName="Member"/>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="No" Checked='true' GroupName="Member"/>
        </fieldset>
        <asp:Button ID="Submit" runat='server' Text="Submit" onclick="Submit_Click" />
    </div>
    
    </form>
</body>
</html>
