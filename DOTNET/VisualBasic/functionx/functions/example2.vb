Module Module1
Function Addition(ByRef num1 as Integer, ByRef num2 as Integer) as Integer
num1 = InputBox("Enter First Number")
num2 = InputBox("Enter Second Number")
Return num1 + num2
End Function

Function Addition1(ByVal num1 as Integer, ByVal num2 as Integer) as Integer
num1 = InputBox("Enter First Number")
num2 = InputBox("Enter Second Number")
Return num1 + num2
End Function


Sub Main()
Dim num1% = 100
Dim num2% = 100


'Console.WriteLine(Addition(num1, num2))
'Console.WriteLine("value of num1 " & num1)
'Console.WriteLine("value of num2 " & num2)

Console.WriteLine(Addition(num1, num2))
Console.WriteLine("value of num1 " & num1)
Console.WriteLine("value of num2 " & num2)

End Sub

End Module
