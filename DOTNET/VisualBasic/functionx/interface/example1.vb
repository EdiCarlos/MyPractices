Interface Interface1
Sub WhoIam()
Function RetName() as String
end Interface

public class Example 
Implements Interface1
public Sub WhoIam() implements Interface1.WhoIam
Console.WriteLine("Arif")
End Sub

public Function RetName() as String Implements Interface1.RetName
RetName = "ARif Khan"
End Function

End Class

Module Module1

public  Sub Main()
Dim ex as new Example()
ex.WhoIam()
Console.WriteLine(ex.RetName())
End Sub

End Module