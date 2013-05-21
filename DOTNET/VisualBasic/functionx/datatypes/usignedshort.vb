Imports System

Module Module1
Sub Main()
Dim var as ushort
try
var = 1
Console.WriteLine(var)
catch
Console.WriteLine("Exception occurred")
finally
Console.WriteLine("This will execute")
end try
End Sub
End Module