using System;
using System.Threading;

class tryEnter
{
public void criticalSection()
{
bool b = Monitor.TryEnter(this, 1000);
Console.WriteLine("Thread " + Thread.CurrentThread.GetHashCode() + " try enter value " + b);
for(int i = 1; i<3; i++)
{
Thread.Sleep(3000);
Console.WriteLine("Thread " + Thread.CurrentThread.GetHashCode() + " try enter value " + b);
} 
Monitor.Exit(this);
}

}
class exe
{
public static void Main()
{
try
{
tryEnter enter = new tryEnter();

Thread t1 = new Thread(new ThreadStart(enter.criticalSection));
t1.Start();
Thread t2 = new Thread(new ThreadStart(enter.criticalSection));
t2.Start();
}
catch(Exception e)
{
Console.WriteLine(e.Message);
}
}
}