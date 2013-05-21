class name
shared dim firstname as String
shared dim lastname as String
shared dim middlename as String

shared property GetFirstName() as String
get 
return name.firstname
end get
set 
name.firstname = value
end set
end property

end class

class showingWith
dim fname as String, lname as String, mname as String

property FirstName() as String
get
return fname
end get
set
fname = value
end set
end Property

property LastName() as String
get
return lname
end get
set
lname = value
end set
end Property

property MiddleName() as String
get
return mname
end get
set
mname = value
end set
end Property

End Class

Module module1

Sub Main()
Dim show as showingWith = new showingWith()
with show
.FirstName = "Arif"
.LastName = "khan"
.MiddleName = "Hasan"
End with

Console.WriteLine(show.FirstName & " " & show.MiddleName & " " & show.LastName)

End Sub
end Module