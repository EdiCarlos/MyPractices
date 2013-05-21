using System;
using System.Threading;

class MainClass
{
public static void Main()
{
Console.WriteLine("Entering main thread");
ThreadPool.QueueUserWorkItem(new WaitCallback(threadProc));
Thread.Sleep(100);
Console.WriteLine("Exiting main thread");
}
static void threadProc(Object obj)
{
for(int i = 0; i < 10; i++)
Console.WriteLine("Hello from thread pool");
}

}

