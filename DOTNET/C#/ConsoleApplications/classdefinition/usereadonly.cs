using System;

class MainClass
{
public static readonly int size = 122;

public  readonly int getsize()
{
return size;
}
public static void Main()
{
size = 200;
Console.WriteLine(size);
}
}