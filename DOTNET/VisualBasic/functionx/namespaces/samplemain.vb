Namespace myname
Module module1

Sub Main()
Dim cl as mycl = new mycl()
cl.ShowConfig()
Dim c as anotherName.cl1 = new anotherName.cl1()
c.mysub()
End Sub
End Module
End Namespace

Namespace anotherName
class cl1
public sub mysub()
Console.WriteLine("call my sub")
end sub
end class
End Namespace