
On Error Resume Next
 
strTarget = "10.63.4.1" 'IP address or hostname
Set objShell = CreateObject("WScript.Shell")
Set objExec = objShell.Exec("ping -n 2 -w 1000 " & strTarget)
strPingResults = LCase(objExec.StdOut.ReadAll)
If InStr(strPingResults, "reply from") Then
  WScript.Echo strTarget & " responded to ping."
  Set objWMIService = GetObject("winmgmts:" _
   & "{impersonationLevel=impersonate}!\\" & strTarget & "\root\cimv2")
  Set colCompSystems = objWMIService.ExecQuery("SELECT * FROM " & _
   "Win32_ComputerSystem")
  For Each objCompSystem In colCompSystems
    WScript.Echo "Host Name: " & LCase(objCompSystem.Name)
  Next
Else
  WScript.Echo strTarget & " did not respond to ping."
End If