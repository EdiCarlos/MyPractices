using System;

public delegate void mydel(ref int x);
class myclass
{
public static void retInt(ref int x)
{
 x += 3;
}
public static void retInt1(ref int y)
{
 y += 5;
}
}
class exe
{
static void Main()
{
mydel del = new mydel(myclass.retInt);
del += myclass.retInt1;

int z = 10;
del(ref z);
Console.WriteLine("Value of z " + z);
}
}