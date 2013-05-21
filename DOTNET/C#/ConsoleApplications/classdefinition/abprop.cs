using System;

public abstract class employee
{
public abstract string Name
{
get;
}
}
class Engineer : employee
{
string name = "Engineer";
public override string Name
{
get
{
return name;
}
}
}
class exe
{
public static void Main()
{
Engineer eng = new Engineer();
Console.WriteLine(eng.Name);
}
}