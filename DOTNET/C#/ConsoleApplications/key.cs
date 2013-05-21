using System;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("key")]

public class Class1
{
public void Test()
{
Console.WriteLine("Class1.Test");
}
}

public class Class2
{
   internal void Test()
   {
    Console.WriteLine("Class2.Test");
   }
}