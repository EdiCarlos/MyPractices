Imports System

public class Name
public sub New()
Console.WriteLine("Constructor called")
end sub
public sub New(ByVal fname as String, ByVal lname as string)
me.fname = fname
me.lname = lname
end sub
private fname as string
private lname as string
public sub EnterName()
me.fname = InputBox("Enter you first name")
me.lname = InputBox("Enter Your last name")
end sub
readonly property fullname() as string
get
return me.lname + " " + me.fname
end get
end property
writeonly property setfname() as string
set(Byval value as string)
me.fname = value
end set
end property
public overridable function myname() as string
return "arif"
end function
public sub changefname(ByRef fname as string)
fname = "arif khan hasan"
end sub

protected overrides sub Finalize()
Console.WriteLine("Destructor called")
end sub
End class


Module Module1
Sub Main()
Dim fname as string = string.Empty
Dim m as Name = new Name("arif", "khan")
'm.setfname = InputBox("Enter your first name")
Console.WriteLine("you full name is " & m.fullname)
m.changefname(fname)
Console.WriteLine(fname)
End Sub
End Module