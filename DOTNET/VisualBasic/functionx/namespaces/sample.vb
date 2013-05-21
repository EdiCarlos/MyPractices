Namespace myname
class mycl
public sub new()
Console.WriteLine("myclass called")
end sub
public Sub ShowConfig()
Console.WriteLine(Environment.MachineName)
Console.WriteLine(Environment.SystemDirectory)

for each  s as String in Environment.GetLogicalDrives()
Console.WriteLine(s)
next

Console.WriteLine(Environment.Version.ToString())
End Sub
end class
end Namespace
