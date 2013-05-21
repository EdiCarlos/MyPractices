using System;
using System.Threading;

namespace myspace
{
class exe
{
static void Main()
{
math m = new math(2, 3);
Thread t1 = new Thread(new ThreadStart(m.Add));
Thread t2 = new Thread(new ThreadStart(m.Subtract));
Thread t3 = new Thread(new ThreadStart(m.Multiply));

t1.Start();
t2.Start();
t3.Start();
}
}
class math
{
public int num1, num2;
public int result;
public math(int _num1, int _num2)
{
num1 = _num1;
num2 = _num2;
}
public void Add()
{
Monitor.Enter(this);
result = num1 + num2;
Console.WriteLine("Add : " + result);
Monitor.Exit(this);
}
public void Subtract()
{
Monitor.Enter(this);
result = num1 - num2;
Console.WriteLine("Subtraction : " + result);
Monitor.Exit(this);
}
public void Multiply()
{
Monitor.Enter(this);
result = num1 * num2;
Console.WriteLine("Multiplication : " + result);
Monitor.Exit(this);
}
}
}