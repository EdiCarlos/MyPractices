MustInherit Public class Shape
public MustOverride Sub Area()
public Overridable Function myString() as String
return "Shape"
End Function
End Class 

class Circle 
   Inherits Shape
   
   public Overrides Sub Area()
   Console.WriteLine("Area")
   End Sub

   public Overrides Function myString() as String
    myString = "Circle"
   end Function

   End Class
   

Module Module1

Sub Main()

Dim cir as new Circle()

Console.WriteLine(cir.myString())

End Sub

End Module