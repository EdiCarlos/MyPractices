Module Module1
Function Foo(Optional ByVal str1 as String = "arif") as String
return str1
End Function
Sub Main()
Console.WriteLine(Foo())
End Sub
End Module