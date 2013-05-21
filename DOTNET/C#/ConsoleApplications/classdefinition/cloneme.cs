using System;

class cloneme : ICloneable
{
public string name, title;
public int age;
public cloneme(string name, string title, int age)
{
this.name = name;
this.title = title;
this.age = age;
}
public object Clone()
{
return MemberwiseClone();
}
public override string ToString()
{
return string.Format("{0}  {1} = Age {2}", name, title, age);
}

}
public class mainClass
{
public static void Main()
{
cloneme cl = new cloneme("arif", "sir", 22);
cloneme cloned = (cloneme)cl.Clone();
Console.WriteLine("Original employee");
Console.WriteLine(cl.ToString());
Console.WriteLine("Cloned Employee");
Console.WriteLine(cloned.ToString());

cl.name = "tarik";
cl.title = "brother";
cl.age = 19;
cloned.name = "aasif";
cloned.title = "friend";
cloned.age = 21;
Console.WriteLine("Original employee");
Console.WriteLine(cl.ToString());
Console.WriteLine("Cloned Employee");
Console.WriteLine(cloned.ToString());

	

}
}