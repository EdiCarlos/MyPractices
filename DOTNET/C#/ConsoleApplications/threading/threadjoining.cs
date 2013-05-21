using System;
using System.Threading;

class myThread
{
public void doSleep()
{
Console.WriteLine("thread Sleeping for 5 seconds");
Thread.Sleep(5 * 1000);
}
public static Thread getThread()
{
myThread my = new myThread();
Thread th = new Thread(new ThreadStart(doSleep));
th.Start();
return(th);
}
}