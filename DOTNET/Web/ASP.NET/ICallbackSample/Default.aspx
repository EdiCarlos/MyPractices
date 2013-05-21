<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <title></title>
    <script type="text/javascript">
        function getFullName() {
            var fName = $("#<%=txtFirstName.ClientID %>").val();
            var lName = $("#<%=txtLastName.ClientID %>").val();
            UseCallback(fName+"|"+lName, "");
        }
        function GetAsyncFullName(fullName, context) {
            $("#<%=txtFullName.ClientID %>").val(fullName);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <label>First Name</label><asp:TextBox ID="txtFirstName" runat="server" />
        <label>Last Name</label><asp:TextBox ID="txtLastName" runat="server" />
        <label>Full Name</label><asp:TextBox ID="txtFullName" runat="server" Text="" />
        <%--    <asp:Button ID="getFullName" runat="server" Text="Submit" OnClientClick="GetAsyncFullName();" />--%>
        <input type='button' value="Get Name" onclick="getFullName()" />
    </div>
    </form>
</body>
</html>
