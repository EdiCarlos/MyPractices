using System;
using System.Threading;

class mythread
{
public Thread th;
public mythread()
{
th = new Thread(this.run);
th.Start();
}
public void run()
{
Console.WriteLine("Starting run program");
for(int i = 0; i < 50; i++)
{
try
{
Console.Write(i + " ");
Thread.Sleep(50);
}
catch(ThreadAbortException e)
{
if((int)e.ExceptionState == 0)
{
Console.WriteLine("Abort Cancelled code is " + e.ExceptionState);
Thread.ResetAbort();
}
else
{
Console.WriteLine("Thread abortin code is " + e.ExceptionState);
}
}
}
Console.WriteLine("Exiting run program");

}
}
class exe
{
public static void Main()
{
Thread thmain = Thread.CurrentThread;

Console.WriteLine("Entering Main thread");
mythread my = new mythread();
Thread.Sleep(2500);
Console.WriteLine(thmain.IsAlive);
Console.WriteLine("Stopping thread");
my.th.Abort(100);
my.th.Join();
Console.WriteLine("Main thread terminating");
}
}