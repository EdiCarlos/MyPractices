using System;

class exe
{
public static void Main()
{
Example example = new Example();
example.Function1();
}
}
class Example
{
static string name = String.Empty;
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
Console.WriteLine(name);

}
}