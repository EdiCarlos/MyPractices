Imports System


Module Module1
public Sub Main()

Dim drive as new  DerivedClass("arif", 22, "khan")
drive.Draw()

Dim b as BaseClass = CType(drive, BaseClass)

b.Draw()
End Sub
End Module

public class BaseClass
public Dim name as String
private Dim age as Integer
public Sub New(ByVal name as String, byVal age as Integer)
me.name = name
me.age = age
End Sub

public Sub Draw()
Console.WriteLine("you name is "& name & " and your age is " & age)
End Sub

End Class

public class DerivedClass
inherits BaseClass
private fname as String
private lname as String
private age as Integer

public Sub New(ByVal fname as String, ByVal age as Integer, byVal lname as String)
MyBase.New(fname, age)
me.fname = fname
me.lname = lname
me.age = age
End Sub

public shadows Sub Draw()
Console.WriteLine("your first name is " & fname & " Last name is " & lname & "your age is " & age)
End Sub

public Sub ShowBaseDraw()
MyBase.Draw()
End Sub
End Class