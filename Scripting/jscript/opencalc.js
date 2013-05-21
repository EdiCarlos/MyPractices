var WshShell = new ActiveXObject("WScript.Shell");
var oExec = WshShell.Exec("");

while (oExec.Status == 0)
{
     WScript.Sleep(100);
}

WScript.Echo(oExec.Status);