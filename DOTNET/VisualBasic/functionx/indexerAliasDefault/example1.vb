Class Example1
private Dim arr(9) as Integer

public Sub New()
End Sub

ReadOnly Property Length() as Integer
get
return arr.Length
end get
end Property


Default Property Item(ByVal Index as Integer) as Integer
get
return arr(Index)
end get
set (ByVal value as Integer)
arr(Index) = value
end set
End Property 

End Class

Module Module1
Sub Main()
dim ex as new Example1

Console.WriteLine(ex.Length)

for i as Integer = 0 to ex.Length - 1
ex(i) = i+1
next

for i as Integer = 0 to ex.Length - 1
Console.WriteLine(ex(i))
next


End Sub

End Module