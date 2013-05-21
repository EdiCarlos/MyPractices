Module module1

Class my

private Dim len as Double = 100
 const str as String = "Arif"

ReadOnly Property GetName() as String
get
return str
end get

End Property
Property GetLen() as Double
Get
Return Me.len
End Get
Set
Me.len = value
End Set
End Property


End Class

Sub Main()

Dim m as new My()

Console.WriteLine(m.GetLen)
m.GetLen= 200
Console.WriteLine(m.GetLen)
Console.WriteLine(m.GetName)
End Sub
End Module