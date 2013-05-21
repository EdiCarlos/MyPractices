using System;

class exe
{
static void Main()
{
int myout, myref;
myref = 200;
exe.getOut(out myout);
exe.getRef(ref myref);
Console.WriteLine("My out variabale value is " + myout);
Console.WriteLine("My ref variabale value is " + myref);

}
public static void getOut(out int v)
{
v = 100;
}
public static void getRef(ref int v)
{
v = 100;
}

}