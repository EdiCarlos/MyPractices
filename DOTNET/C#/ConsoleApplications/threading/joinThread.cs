using System;
using System.Threading;

class jnthread
{
public static void Main()
{
jnthread j = new jnthread();
Thread mythread = new Thread(new ThreadStart(j.ThreadProc));
Thread theirthread = new Thread(new ThreadStart(j.ThreadProc));
theirthread.Start();
mythread.Start();
mythread.Join();
}
public  void ThreadProc()
{
Monitor.Enter(this);
for(int i = 0; i < 100; i++)
{
Console.WriteLine(i);
}
Monitor.Exit(this);
}
}