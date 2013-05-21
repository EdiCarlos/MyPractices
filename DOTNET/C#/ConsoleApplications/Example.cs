using System;

class exe
{

}
class Example
{
string name = String.Empty;
static Example()
{
name = "static string";
}
public Example()
{
name = "simple string";
}
public void Function1()
{
Console.WriteLine(name);
}
public static void Function2()
{
Console.WriteLin(new Example().name);

}
}