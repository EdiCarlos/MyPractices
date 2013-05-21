<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnEncode_Click(object sender, EventArgs e)
    {
        txtEncoded.Text = SalarSoft.ASProxy.UrlEncoders.EncodeToASProxyBase64(txtEncode.Text);
    }

    protected void btnDecode_Click(object sender, EventArgs e)
    {
        txtDecoded.Text = SalarSoft.ASProxy.UrlEncoders.DecodeFromASProxyBase64(txtDecode.Text);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASProxy Modified Base64!</title>
</head>
<body>
    <form id="frmBase64" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Encode"></asp:Label>
    <br />
    <asp:TextBox ID="txtEncode" runat="server" Columns="70"></asp:TextBox>
    <asp:Button ID="btnEncode" runat="server" Text="Encode" 
        onclick="btnEncode_Click" />
    <br />
        <asp:TextBox ID="txtEncoded" runat="server" Height="300px" TextMode="MultiLine" 
        Width="600px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Decode"></asp:Label>
    <br />
    <asp:TextBox ID="txtDecode" runat="server" Columns="70"></asp:TextBox>
    <asp:Button ID="btnDecode" runat="server" Text="Decode" 
        onclick="btnDecode_Click" />
    <br />
    <asp:TextBox ID="txtDecoded" runat="server" Height="300px" TextMode="MultiLine" 
        Width="600px"></asp:TextBox>
    <br />
    
    
    </form>
</body>
</html>
