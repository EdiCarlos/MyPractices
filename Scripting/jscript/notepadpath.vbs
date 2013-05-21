
strComputer = "."
Set objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")

Set colProcessList = objWMIService.ExecQuery _
    ("Select * from Win32_Process Where Name = 'notepad.exe'")

For Each objProcess in colProcessList
    Wscript.Echo objProcess.ExecutablePath
Next