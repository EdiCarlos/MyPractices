<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function GetName() {
            GetNameService.GetFullName("Arif", callback, onfail, usercontext);
        }
        function callback(result) {
            alert(result.FirstName);
            alert(result.LastName);
            alert(result.MiddleName);
        }
        function onfail(result) {
        }
        function usercontext(context) {
        }
    </script>
</head>
<body>
    <input type="button" onclick="GetName()" value="Get Name" />
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Services>
                    <asp:ServiceReference Path="http://localhost:18588/GetNameService.svc" />
                </Services>
            </asp:ScriptManager>
        </div>
    </form>
</body>
</html>
