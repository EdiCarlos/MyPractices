<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #ResDiv
        {
            height: 19px;
            text-align: center;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="Default.aspx.js" />
            </Scripts>
            <Services>
                <asp:ServiceReference Path="Athletes.asmx" />
            </Services>
        </asp:ScriptManager>
<script type="text/javascript">
   

</script>
        <br />
        <input id="txtService" type="text" style="width: 230px" />
        <br />
        <br />
        <input id="btnGetAthletes" type="button" value="Get Athletes by Weight" onclick="GetAthletesByWeight()" style="width: 240px" title="Complex Network Callback" /><br />
        <br />
        </div>
        <div id="ResDiv">
        </div>
    </form>

<p>
    &nbsp;</p>

</body>
</html>
