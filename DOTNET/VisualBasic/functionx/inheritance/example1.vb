
Module mod1
Sub Main()
Dim b As B = new B()

End Sub
End Module

public Class A

public Sub New()
Console.WriteLine("Base Class Constructor Called")
End Sub
End Class

public Class B 
Inherits A
public Sub New()
Console.WriteLine("Class Construtor called")
End Sub
End Class
