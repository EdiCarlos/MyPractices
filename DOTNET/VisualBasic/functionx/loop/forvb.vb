
Module Module1
'Use of For Loop

Sub ForLoop()
Dim i As Integer = 0
For i = 1 to 10
Console.WriteLine(i)
Next

End Sub

'Use of Do Loop

Sub DoLoop()
Dim i as Integer = 0
Dim j as Integer = 10
do while i < j
Console.Write(i)
i = i + 1
loop
End Sub

Sub DoUntil()
Dim i As Integer
do until i >= 100
i  = i + 1
Console.Write(i)
loop
End Sub
'Begins main function
Sub Main()
ForLoop()
DoLoop()
DoUntil()
End Sub
End Module