using System;
using System.Threading;

class MainClass
{
public static void doCount()
{
for(int i = 0; true; i++)
{
Console.WriteLine(" {0} reached {1} ", Thread.CurrentThread.Name, i); 
}
}
static void Main()
{
Console.WriteLine("Entering main thread");
Thread [] th = new Thread[10];
for(int i= 0; i < th.Length; i++)
{
th[i] = new Thread(new ThreadStart(doCount));
th[i].IsBackground = true;
th[i].Name = "Thread " + i;
th[i].Start();
}
Thread.Sleep(5 * 1000);
Console.WriteLine("Exiting main thread");
}
}