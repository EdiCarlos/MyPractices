Module Module1
Function GetTime(ByVal str As String) As String
return str & Cstr(now)
End Function
Sub DisplayTime()
MsgBox(GetTime("Date: "))
End Sub

Sub Main()
DisplayTime()
End Sub
End Module