using System;
using System.Threading;

class mythread
{
public static int count = 0;
public static void Main(String [] args)
{
Console.WriteLine(Thread.CurrentThread.GetHashCode());
myclass my = new myclass();
if(count == 0)
{
Thread thr = new Thread(new ThreadStart(myclass.mymethod));
thr.Start();
Console.WriteLine("Aborting thread");
thr.Abort();
}
}
}
public class myclass
{
public static void mymethod()
{
}
}