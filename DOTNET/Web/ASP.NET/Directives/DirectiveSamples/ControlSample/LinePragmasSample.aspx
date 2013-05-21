<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinePragmasSample.aspx.cs" Inherits="ControlSample.LinePragmasSample" CompilationMode="Auto" LinePragmas="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script runat="server">
    protected void Button1_Click(object sender, EventArgs e) {
        Label1.Text = Server.HtmlEncode(TextBox1.Text);
    }
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
           <asp:TextBox ID="TextBox1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label" />
 
    </div>
    </form>
</body>
</html>
