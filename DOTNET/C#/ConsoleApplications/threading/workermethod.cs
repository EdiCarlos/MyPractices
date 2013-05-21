using System;
using System.Threading;

class exe
{
public static void Main()
{
exe.runThread();
exe.runThreadDel();
}
public static void runThread()
{
int count = 5;
Thread [] th = new Thread[count];
for(int i = 0; i < count; i++)
{
int idx = i;
th[i] = new Thread(delegate() {Console.WriteLine("Worker {0} " , idx); Console.WriteLine("Thread id " + Thread.CurrentThread.GetHashCode());});
th[i].Start();
}
}
public static void runThreadDel()
{
int count = 5;
Thread[] th = new Thread[count];
for(int i = 0; i < count; i++)
{
int idx = i;
th[i] = new Thread(delegate() {Console.WriteLine("Worker {0}", idx); Console.WriteLine("thread id " + Thread.CurrentThread.GetHashCode());});
}
Array.ForEach(th, delegate(Thread t){t.Start();});
}
}