Imports System
Imports System.Text

Module Module1
declare function getCommandLine lib "kernel32" alias "GetCommandLineA" () as long

declare function getUserName lib "advapi32.dll" alias "GetUserNameA" _
(ByVal user as String, ByVal buffer as Integer) as Integer

Sub Main()
Dim username as String = new String(CChar(" "), 256)
Dim retVal as Integer = getUserName(username, 256)
Console.WriteLine(username)
End Sub
End Module