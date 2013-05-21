using System;
using System.Threading;

class mythread
{
public Thread th;
public mythread(string name, int count)
{
th = new Thread(new ParameterizedThreadStart(this.run));
th.Name = name;
th.Start((object)count);
}
public void run(object count)
{
Console.WriteLine("Thread domain name "+ Thread.GetDomain().FriendlyName);

for(int i = 0; i < (int)count; i++)
{
Thread.Sleep(500);
Console.WriteLine("Thread name {0} worker state {1}",th.Name,  Thread.CurrentThread.ThreadState);
}
}
}
class exe
{
public static void Main()
{
Console.WriteLine("Entering main thread");
mythread my = new mythread("child 1", 100);
mythread my1 = new mythread("child 2",10);
mythread my2 = new mythread("child 3",50);
mythread my3 = new mythread("child 4",70);

while(my.th.IsAlive || my1.th.IsAlive || my2.th.IsAlive || my3.th.IsAlive)
{
Console.WriteLine("main still waiting");
Thread.Sleep(1000);
}
Console.WriteLine("Exiting main thread");

}
}