
Set objWMIService = GetObject("winmgmts:")
Set colNicConfig = objWMIService.ExecQuery("SELECT * FROM " & _
  "Win32_NetworkAdapterConfiguration WHERE IPEnabled = True")
For Each objNicConfig In colNicConfig
  WScript.Echo "Network Adapter: " & objNicConfig.Index
  WScript.Echo "  DHCP Enabled: " & objNicConfig.DHCPEnabled
Next