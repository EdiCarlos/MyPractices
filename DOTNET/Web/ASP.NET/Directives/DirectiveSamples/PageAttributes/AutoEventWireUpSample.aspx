<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="AutoEventWireUpSample.aspx.cs" Inherits="PageAttributes.AutoEventWireUpSample" EnableTheming="False" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script runat='server'>
    void Page_Load(object sender, EventArgs e)
    {
        Response.Write("This is page load event");
    }
</script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Label ID="lblNoteLabel" runat="server" Text="Note: " SkinID="lblBold" />
    <asp:Label ID="lblNote" runat="server"  Text=" Default value of AutoEventWireUp is (true)." SkinID="lblNote"></asp:Label>

    </div>
    </form>
</body>
</html>
