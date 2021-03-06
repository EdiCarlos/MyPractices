Imports System

Namespace MyDelUsage

public delegate sub MyEventHandler(ByVal a as Integer)
public delegate Function AddNumbersHandler(ByVal num1 as Integer, ByVal num2 as Integer) as Double
public delegate Sub SimpleHandler()

Class Example1

public Sub New()
Console.WriteLine("Example1 constructor called")
End Sub

public Sub ShowNumber(ByVal num1 as Integer)
Console.WriteLine(num1)
End Sub

public Function AddNumber(ByVal num1 as Integer, ByVal num2 as Integer) as Double
AddNumber = num1 + num2
End Function

public Sub Simple1()
Console.WriteLine("Simple1")
End Sub

public Sub Simple2()
Console.WriteLine("Simple2")
End Sub

End Class

Module Module1

Sub Main()

Dim exe as new Example1

Dim eve as AddNumbersHandler = addressof exe.AddNumber

Dim sim() as SimpleHandler = new SimpleHandler(){addressof exe.Simple1, addressof exe.Simple2}
Dim del as SimpleHandler = MultiCastDelegate.Combine(sim)

Console.WriteLine(eve.Invoke(10, 20)) 
del.Invoke()
End Sub

End Module

End Namespace