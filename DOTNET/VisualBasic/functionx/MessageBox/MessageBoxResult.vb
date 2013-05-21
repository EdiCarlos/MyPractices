Module Module1

Function Main() as Integer
Dim result as MsgBoxResult

result = MsgBox("Are you arif ", MsgBoxStyle.Question or MsgBoxStyle.OkCancel, _
"Question ?")

Console.WriteLine(IIF(result = MsgBoxResult.Ok, "Yes it is Arif", "No it is not Arif"))
End Function

End Module