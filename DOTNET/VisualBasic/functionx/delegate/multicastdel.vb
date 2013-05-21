Imports System


Class Example1

public Delegate Sub SimpleHandler()
public Sub Simple1()
Console.WriteLine("Simple1")
End Sub

public Sub Simple2()
Console.WriteLine("Simple2")
End Sub

public Shared Sub Function1()
Console.WriteLine("Static Function Delegate")
End Sub

shared Sub Main()

Dim exe as new Example1

Dim del() as SimpleHandler = new SimpleHandler(){ addressof exe.Simple1, addressof exe.Simple2}
Dim stat as SimpleHandler = new SimpleHandler(addressof Example1.Function1)
Dim sim as SimpleHandler = MultiCastDelegate.Combine(del)
sim.Invoke()
stat()

End Sub

End Class