Module Module1
Sub Main()


Try
  Dim aNumber As Double = CDbl("100.00")
  MsgBox("You entered the number " & aNumber)
Catch
  MsgBox("Please enter a number.")
Finally
  MsgBox("Why not try it again?")
End Try
End Sub
End Module