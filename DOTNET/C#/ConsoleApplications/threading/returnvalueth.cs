using System;
using System.Threading;

namespace myname
{
public  delegate void ResultDelegate(int value);

class exe
{
static void Main()
{
multiply m= new multiply("hello world", 13, new ResultDelegate(ResultCallback));
Thread t = new Thread(new ThreadStart(m.ThreadProc));
t.Start();
Console.WriteLine("Main thread does some work, then waits.");
t.Join();
Console.WriteLine("thread completed");
Console.ReadKey();
}
public static void ResultCallback(int ret)
{
Console.WriteLine("Returned value {0}", ret);
}
}
class multiply
{
public string greeting;
public int num;
public ResultDelegate callback;

public multiply(string greeting, int num, ResultDelegate callback)
{
this.greeting = greeting;
this.num = num;
this.callback = callback;
}
public void ThreadProc()
{
Console.WriteLine(this.greeting);
if(callback != null)
{
callback(num * 2);
}
}
}
}