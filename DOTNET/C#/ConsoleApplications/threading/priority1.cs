using System;
using System.Threading;

class mythread
{
public Thread thr;
public int count;
public mythread(string name)
{

thr = new Thread(new ThreadStart(this.run));
thr.Name = name;
thr.Start();
count = 0;
}
void run()
{
do
{
count++;
Console.WriteLine("{0} in {1}", thr.Name , thr.Priority);
}while(count < 2000);

}
}
class exe
{
public static void Main()
{
mythread mt1 = new mythread("1");
mythread mt2 = new mythread("2");
mt1.thr.Priority = ThreadPriority.AboveNormal;
mt2.thr.Priority = ThreadPriority.BelowNormal;
Thread.Sleep(1000);

}
}