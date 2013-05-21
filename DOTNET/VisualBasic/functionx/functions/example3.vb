Imports System

Module Module1
Function Addition(ByRef num1 as String, ByRef num2 as String) as String
num1 = InputBox("Enter First Number")
num2 = InputBox("Enter Second Number")
Return num1 + " " + num2
End Function



Sub Main()


'Console.WriteLine(Addition(num1, num2))
'Console.WriteLine("value of num1 " & num1)
'Console.WriteLine("value of num2 " & num2)

Dim num1 as String
Dim num2 as String
num1 = String.Empty
num2 = String.Empty
Console.WriteLine(Addition(num2 := num1, num1 := num2))
Console.WriteLine("value of num1 " & num1)
Console.WriteLine("value of num2 " & num2)

End Sub

End Module
