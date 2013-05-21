public Class example
public Dim num1 as Integer
public Dim num2 as Integer

public Sub New(ByVal num1 as Integer, ByVal num2 as Integer)
me.num1 = num1
me.num2 = num2
End Sub

public Sub ShowNumbers()
Console.WriteLine(num1)
Console.WriteLine(num2)
End Sub

public shared Operator = (cl as example, cl1 as example) as Boolean
dim flag as Boolean
if cl.num1 = cl1.num1 and cl.num2 = cl1.num2 then
flag = true
else
flag = false
end if
Return flag
End Operator 

public shared Operator <>(cl as example, cl1 as example) as Boolean
dim flag as Boolean
if cl.num1 <> cl1.num1 and cl.num2 <> cl1.num2 then
flag = true
else
flag = false
end if 
Return flag
End Operator

public shared Operator + (cl as example, cl1 as example) as example 
cl.num1 += cl1.num1
cl.num2 += cl1.num2
Return cl
end Operator

public shared Operator / (cl as example, cl1 as example) as example
return cl
end Operator

public shared operator - (cl as example) as Integer
cl.num1 -= 1
return cl.num1
end operator

End Class

Module Module1
Sub Main()
Dim obj1 as example = new example(10, 20)
Dim obj2 as example = new example(10, 30)
Console.WriteLine(obj1 = obj2)
Console.WriteLine(obj1 <> obj2)
Dim o as example = obj1 + obj2
Console.WriteLine(o.num1)
Console.WriteLine(o.num2)
for i as Integer = 1 to 10
Console.WriteLine(-obj1)
next i

Console.WriteLine(Choose(30, obj1.num2, obj2.num2))
Console.WriteLine(IIf(obj1.num1 < obj2.num2, true, false))


End Sub
End Module