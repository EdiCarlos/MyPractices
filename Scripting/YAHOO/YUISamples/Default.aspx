<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="sam/container.css" />
    <!-- OPTIONAL: You only need the YUI Button CSS if you're including YUI Button, mentioned below. -->
    <link rel="stylesheet" type="text/css" href="http://localhost/yui/build/button/assets/skins/sam/button.css" />
    <!-- Dependencies -->

    <script src="http://localhost/yui/build/yahoo-dom-event/yahoo-dom-event.js"></script>

    <!-- OPTIONAL: Animation (only required if using ContainerEffect) -->

    <script src="http://localhost/yui/build/animation/animation-min.js"></script>

    <!-- OPTIONAL: Connection (only required if using asynchronous form submission) -->

    <script src="http://localhost/yui/build/connection/connection-min.js"></script>

    <!-- OPTIONAL: Drag & Drop (only required if enabling Drag & Drop) -->

    <script src="http://localhost/yui/build/dragdrop/dragdrop-min.js"></script>

    <!-- OPTIONAL: YUI Button (these 2 files only required if you want SimpleDialog to use YUI Buttons, instead of HTML Buttons) -->

    <script src="http://localhost/yui/build/element/element-min.js"></script>

    <script src="http://localhost/yui/build/button/button-min.js"></script>

    <!-- Source file -->

    <script src="http://localhost/yui/build/container/container-min.js"></script>

    <title>Simple Dialog Box</title>
</head>
<body class="yui-skin-sam">
    <form id="form1" runat="server">
    <div>
        <a href="http://www.google.com" id="link" title="do you yahoo?">hover me to see link
            tooltip</a>
        <asp:Button ID="button1" runat="server" Text="Click me" />
        <input type="button" id="button2" value="Click me HTML" />

        <script type='text/javascript' language="javascript">
//           button1.onclick = showPopup(100, 200);
//            function showPopup(x, y)
//            {
          mySimpleDialog = new YAHOO.widget.SimpleDialog("dlg", {
             xy: [200, 100],
             zindex: 15000,
             width: "20em",
             effect: {
                 effect: YAHOO.widget.ContainerEffect.FADE,
                 duration: 0.25
             },
             fixedcenter: true,
             modal: true,
             visible: false,
             draggable: false, 
             height: "200px",
         });
 
         mySimpleDialog.setHeader('Warning!');
         mySimpleDialog.setBody('<div><label>UserName : </label><input type="text" id="txtuser" /></div>');
         mySimpleDialog.cfg.setProperty('icon', YAHOO.widget.SimpleDialog.ICON_INFO);
         mySimpleDialog.render(document.body);
         mySimpleDialog.show();         
//        }
        </script>

    </div>
    </form>
</body>
</html>
