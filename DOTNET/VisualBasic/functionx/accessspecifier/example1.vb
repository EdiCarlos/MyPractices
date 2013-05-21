Imports System



Module Module1
Friend Dim fname$ = "arif"
Sub Main()
Module2.ShowName()
End Sub

Class mycl
Friend shared Dim name$ = "static variable"
End Class

End Module

Module Module2
Friend Dim name$ = Module1.fname
Sub ShowName()
Console.WriteLine(name)
Console.WriteLine(Module1.mycl)
End Sub
End Module