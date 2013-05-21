<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AssemblySample._Default" %>
<%@ Assembly Name="AssemblyExtensionMethods" %>
<%@ Assembly Name="AssemblyCalc" %>
<%--<%@ Register Namespace="AssemblyExtensionMethods" %>--%>
<%@ Assembly Src="~/JoinNames.cs"  %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<script runat="server">
    void Page_Load(object sender, EventArgs e)
    {
        int result = 0;
        result = new AssemblyCalc.Calculator().Add(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
        txtResult.Text = result.ToString();

        //txtFullName.Text = AssemblySample.
    }
</script>
</head>
<body>
<form id="form1" runat="server">
<asp:TextBox ID="txtNum1" runat="server" Text="10" />
<br />
<asp:TextBox ID="txtNum2" runat="server" Text="10" />
<br />
<asp:Button ID="btnAddition" Text="+" runat="server" OnClick="btn_Result" />

<%--<asp:Button ID="btnSubtration" Text="-" runat="server" OnClick="btn_Result" />
<asp:Button ID="btnDiv" Text="/" runat="server" OnClick="btn_Result" />
<asp:Button ID="btnMul" Text="*" runat="server" OnClick="btn_Result" />
--%>
<br />
<asp:TextBox ID="txtResult" runat="server" Text="">
</asp:TextBox>
<asp:TextBox ID="txtFullName" runat="server" Text="">
</asp:TextBox>

</form>

</body>
</html>
