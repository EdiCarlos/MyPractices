using System;
public class genericList<T>
{

public genericList(T str)
{
Console.WriteLine(str);
}
public static void show(T str)
{
Console.WriteLine(str);
}
public void display(T str)
{
Console.WriteLine(str);
}

}
public class exe
{
public static void Main(string [] args)
{
string var = "Hello world";
genericList<string> gen = new genericList<string>(var);
genericList<int>.show(1000);
gen.display("hello world");

}
}