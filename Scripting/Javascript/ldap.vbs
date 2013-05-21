  Set objSysInfo = CreateObject("ADSystemInfo")
objSysInfo.RefreshSchemaCache
WScript.Echo "User name: " & objSysInfo.UserName
