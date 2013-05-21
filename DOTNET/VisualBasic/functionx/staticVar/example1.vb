
Module Module1

Function Starter(ByVal num1 as Integer) as Integer
 Dim num as Integer = Ctype(Console.ReadLine(), Integer)
num = num + num1
Return num
End Function

Sub Main()
Dim num1$ = "1000"
Console.WriteLine(CType(num1, UInteger))
Console.WriteLine(CType(17422, Short))
Console.WriteLine(Starter(10))
Console.WriteLine(Starter(10))
Console.WriteLine(Starter(10))
Console.WriteLine(Starter(10))


End Sub
End Module