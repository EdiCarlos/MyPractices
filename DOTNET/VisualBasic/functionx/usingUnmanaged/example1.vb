Module Module1

Declare Function getUserName Lib "advapi32.dll" Alias "GetUserNameA" _
    (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
Sub getUser()
    Dim buffer As String = New String(CChar(" "), 25)
    Dim retVal As Integer = getUserName(buffer, 25)
    Dim userName As String = Strings.Left(buffer, InStr(buffer, Chr(0)) - 1)
    
    MsgBox(userName)
End Sub

Sub Main()
getUser()
End Sub
End Module