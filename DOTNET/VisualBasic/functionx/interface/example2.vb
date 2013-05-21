Interface Interface1
Property GetFullName() as String
Sub Fun1()
Function ShowData() as String
end Interface

class userInter 
implements Interface1
public Dim name as String

Sub Fun1() implements Interface1.Fun1
Console.WriteLine("Fun1")
End Sub

public Function ShowData()as String implements Interface1.ShowData
ShowData = "ShowData"
End Function 

Public Property GetFullName() as String implements Interface1.GetFullName
get
return name
end get

set (ByVal value as String)
name = value
end set
End Property

end Class

Module Module1

Sub Main()
Dim user as new userInter()
user.GetFullName = "Arif khan"
Console.WriteLine(user.GetFullName)
End Sub
End Module