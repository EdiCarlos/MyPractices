Class BaseClass
public Sub New(ByVal fname as String)
Console.WriteLine(fname)
End Sub
End Class

Class DerivedClass
  inherits BaseClass
  
  public Sub New(ByVal fname as String, ByVal lname as String) 
  MyBase.New(fname)
  Console.WriteLine(fname & " " & lname)
  End Sub
End Class
Module Module1
Sub Main()

Dim drive as new DerivedClass("Aarif", "Khan")


End Sub
End Module