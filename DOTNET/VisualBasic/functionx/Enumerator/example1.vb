public Enum DaysOfWeek
Sunday
 Monday
  Tuesday
   Wednesday
 Thursday
  Friday
   Saturday
End Enum

Module module1
Sub Main()
Console.WriteLine("1. Sunday ")
Dim choice as Integer = CInt(Console.ReadLine())

Dim day as DaysOfWeek = choose(choice, DaysOfWeek.Sunday, DaysOfWeek.Monday, DaysOfWeek.Tuesday, DaysOfWeek.Wednesday, DaysOfWeek.Thursday, DaysOfWeek.Friday, DaysOfWeek.Saturday)

Console.WriteLine(CStr(day))

End Sub

end Module