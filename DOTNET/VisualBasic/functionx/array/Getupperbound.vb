Module Module1
Sub Main()
Dim arr(3) as Integer

for i as Integer = 0 to arr.GetUpperBound(0)
arr(i) = i
next
for each j as Integer in arr
Console.WriteLine(arr(j))
next

End Sub
End Module