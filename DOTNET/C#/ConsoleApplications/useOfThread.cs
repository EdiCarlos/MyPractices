using System;
using System.Threading;

public class TestClass
{
public string boilerPlate;
public int Value;

public TestClass(string str, int val)
{
this.boilerPlate = str;
this.Value = val;
}
}
class exe
{
public static void Main()
{
TestClass ti = new TestClass("This report display report number {0} ", 42);
if(ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc), ti))
{
Console.WriteLine("Main thread is doing some work then sleeps");
Thread.Sleep(1000);
Console.WriteLine("Main Thread Sleeps");
}
else
{
Console.WriteLine("Unable to queue the thread");
}
}
public static void ThreadProc(object obj)
{
TestClass cl = obj as TestClass;
Console.WriteLine(cl.boilerPlate, cl.Value);
}
}
