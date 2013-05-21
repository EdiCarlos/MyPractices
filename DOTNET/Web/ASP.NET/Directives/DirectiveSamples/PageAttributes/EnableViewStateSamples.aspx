<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnableViewStateSamples.aspx.cs" Inherits="PageAttributes.EnableViewStateSamples" EnableViewState="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script runat="server">
        void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                HtmlGenericControl control = new HtmlGenericControl();
                control.InnerHtml = textBox1.Text == string.Empty ? "textBox1 doesn't contain any string" : textBox1.Text;
                this.Controls.Add(control);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" id="textBox1" EnableViewState="false"/>
         <asp:Button runat='server' ID="button" PostBackUrl="~/EnableViewStateSamples.aspx" Text="Submit"/>
    </div>
    </form>
</body>
</html>
