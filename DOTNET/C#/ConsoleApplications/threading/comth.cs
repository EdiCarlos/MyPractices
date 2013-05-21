using System;
using System.Threading;

class Sum
{
public Sum(int num1, int num2)
{
Console.WriteLine("[sum.sum] Instantiated with values of {0} and {1} ", num1, num2);
this.num1 = num1;
this.num2 = num2;
}
public int num1, num2, result;
public void Add()
{
result =  num1 + num2;
}
}
class exe
{
public static void Main()
{
Sum m = new Sum(10, 20);
Thread th = new Thread(new ThreadStart(m.Add));
th.Start();
for(int i= 0; i < 10; i++)
{
Thread.Sleep(500);
Console.Write(".");
}
th.Join();
Console.WriteLine("Main result is " + m.result);
}
}