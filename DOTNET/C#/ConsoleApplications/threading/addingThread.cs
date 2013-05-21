using System;
using System.Threading;

class AddParam
{
public int x;
public int y;
public AddParam(int num1, int num2)
{
this.x = num1;
this.y = num2;
}
}
class exe
{
public void Run(object addp)
{
if(addp is AddParam)
{
Console.WriteLine("Thread id " + Thread.CurrentThread.GetHashCode());
AddParam a = (AddParam)addp;
Console.WriteLine("{0} + {1} is {2} ", a.x, a.y, a.x + a.y);
}
}
public static void Main()
{
Console.WriteLine("Current thread id " + Thread.CurrentThread.GetHashCode());
AddParam add = new AddParam(10, 20);
exe e = new exe();
Thread th = new Thread(new ParameterizedThreadStart(e.Run));
th.Start(add);
Thread.Sleep(1000);

Console.WriteLine("Task Completed");
}
}