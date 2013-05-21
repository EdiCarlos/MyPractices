
On Error Resume Next
 
strComputer = "client1"
Set objWMIService = GetObject("winmgmts:" _
 & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
Set colNicConfigs = objWMIService.ExecQuery _
 ("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True")
 
WScript.Echo VbCrLf & "Computer Name: " & strComputer
WScript.Echo " IP Addresses & Subnet Masks"
 
For Each objNicConfig In colNicConfigs
  WScript.Echo VbCrLf & "  Network Adapter " & objNicConfig.Index
  WScript.Echo "    " & objNicConfig.Description & VbCrLf 
  WScript.Echo "    IP Address(es):"
  For Each strIPAddress In objNicConfig.IPAddress
    WScript.Echo "        " & strIPAddress
  Next
  WScript.Echo "    Subnet Mask(s):"
  For Each strIPSubnet In objNicConfig.IPSubnet
    WScript.Echo "        " & strIPSubnet
  Next
Next