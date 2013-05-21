<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleWeb.aspx.cs" Inherits="CustomAuthenticationWeb.SampleWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="http://localhost:1556/ICustomAuthenticationService.svc/ajax" />
            </Services>
        </asp:ScriptManager>
            <script type="text/javascript">
                Custom.ICustomAuthenticationService.GetFullName(name, onSuccess, null, null);
                function onSuccess(result) {
                    alert(result.FirstName +" " +result.LastName + " " + result.MiddleName);
                }
    </script>

    </div>
    </form>
</body>
</html>
