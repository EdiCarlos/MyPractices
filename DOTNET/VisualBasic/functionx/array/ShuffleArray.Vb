Public Class Tester

Shared Sub Main()
Dim array() as String = {"A", "B", "C", "D"}

For each str as String in array
Console.Write(str & " " )
next
Shuffle(array)

Console.WriteLine()

For each str as String in array
Console.Write(str & " " )
next

End Sub

Public Shared Sub Shuffle(ByRef obj as Object)
Dim ran as Random
Dim newPosition as Integer
Dim newObj as Object

ran = new Random()

for counter as Integer  = 0 to obj.Length - 1
newPosition = ran.Next(0, obj.Length - 1)
newObj = obj(counter)
obj(counter) = obj(newPosition)
obj(newPosition) = newObj
next counter

End Sub

End Class
