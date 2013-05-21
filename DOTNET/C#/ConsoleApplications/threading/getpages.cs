using System;
using System.Text;
using System.Net;
using System.Threading;
using System.IO;
class exe
{
public static void Main()
{

for(int i = 0; i < 25; i++)
{
ThreadPool.QueueUserWorkItem(getPages, i);
}
Thread.Sleep(6 * 1000);
Console.WriteLine("Exiting main thread");
}
public static void getPages(object count)
{
Console.WriteLine("\n get page method is begining \n");
Console.WriteLine(Thread.CurrentThread.GetHashCode());
for(int i = 0; i < 10000; i++)
{
Console.Write(i +" " );
}
}
}