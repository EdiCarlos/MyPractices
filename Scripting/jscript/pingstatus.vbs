
On Error Resume Next
 
strComputer = "."
strTarget = "10.63.4.145" 'IP address or hostname
Set objWMIService = GetObject("winmgmts:" _
 & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
Set colPings = objWMIService.ExecQuery _
 ("Select * From Win32_PingStatus where Address = '" & strTarget & "'")
If Err = 0 Then
  Err.Clear
  For Each objPing in colPings
    If Err = 0 Then
      Err.Clear
      If objPing.StatusCode = 0 Then
        Wscript.Echo strTarget & " responded to ping."
        Wscript.Echo "Responding Address: " & objPing.ProtocolAddress
        Wscript.Echo "Responding Name: " & objPing.ProtocolAddressResolved
        Wscript.Echo "Bytes Sent: " & objPing.BufferSize
        Wscript.Echo "Time: " & objPing.ResponseTime & " ms"
        Wscript.Echo "TTL: " & objPing.ResponseTimeToLive & " seconds"
      Else
        WScript.Echo strTarget & " did not respond to ping."
        WScript.Echo "Status Code: " & objPing.StatusCode
      End If
    Else
      Err.Clear
      WScript.Echo "Unable to call Win32_PingStatus on " & strComputer & "."      
    End If
  Next
Else
  Err.Clear
  WScript.Echo "Unable to call Win32_PingStatus on " & strComputer & "."
End If