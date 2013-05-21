Module Module1
Function ITuesday(ByVal i as Integer) As Boolean 

Dim check as Boolean 

check = false

if i = 1 Then
check = true
else
check = false
end if

return check
End Function

Sub SelectCase(ByVal i as integer)
Select case i
case 1 to 3
msgbox("you selected 1 to 3")
case 4, 5, 6
msgbox("you entered value between 4 and 6")
case is > 10
msgbox(cstr(i)+" is greater than 10")
case 7 to 10
msgbox("you entered value between 7 and 10")
end select
End Sub
Sub Main()

Console.WriteLine(My.Computer.Clock.LocalTime)
Console.WriteLine(ITuesday(1))
SelectCase(11)
End Sub
End Module