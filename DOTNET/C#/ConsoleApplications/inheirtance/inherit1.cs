using System;

class a
{
public a(string var)
{
Console.WriteLine(var);
}
public a(string var1, string var2)
{
Console.WriteLine("second constructor called");
Console.WriteLine(var1 + " " + var2);
}
public void show()
{
Console.WriteLine("Class A");
}
}
class b : a
{
public b(string var) :base("1", "2")
{
Console.WriteLine(var);
}
new public void show()
{
Console.WriteLine("Class B");
}
}
class c : b
{
public c():base("2")
{
Console.WriteLine("3");
}
new public void show()
{
Console.WriteLine("Class C");
}
}
class exe
{
static void Main()
{
c obj = new c();
obj.show();
((b)obj).show();
((a)obj).show();
}
}