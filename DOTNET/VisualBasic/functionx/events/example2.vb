Class Example
public Event XEvent()
public Event YEvent()

public Sub ShowEvent()
    RaiseEvent XEvent()
    RaiseEvent YEvent()
End Sub 

End Class


class Example1 
Dim WithEvents exe AS Example
public Sub New()
exe = new Example()
End Sub

public Sub CallShowEvents()
exe.ShowEvent()
End Sub

public Sub ShowEvent_Handler() Handles exe.XEvent, exe.YEvent
Console.WriteLine("Both XEvent and YEvent Called")
End Sub
End Class

Module module1
Sub Main()
Dim example as new  Example1()
example.CallShowEvents()
End Sub

End Module