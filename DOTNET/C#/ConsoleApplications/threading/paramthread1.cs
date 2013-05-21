using System;
using System.Threading;

class exe
{
public static void Main()
{
Thread th = new Thread(new ParameterizedThreadStart(delegate(object obj, object obj2){run(obj, obj2);}));
th.Start(10, 20);
}
public  void run(object obj1, object obj2)
{
Thread.Sleep(200);
Console.WriteLine("{0} and {1} " , obj1, obj2);
}
}