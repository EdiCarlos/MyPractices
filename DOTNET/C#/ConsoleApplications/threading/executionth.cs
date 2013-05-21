using System;
using System.Threading;

class myThread
{
public int count;
public string name;
public myThread()
{
this.count = 0;
this.name = String.Empty;
}
public void run()
{
Console.WriteLine("Run thread starting");
do
{
Console.WriteLine("Run .. ");
count++;
}while(count <= 10);

}
}
class exe
{
public static void Main()
{
myThread th = new myThread();
Thread th1 = new Thread(new ThreadStart(new ThreadStart(th.run)));
th1.Start();
do
{
Console.Write(".");
Thread.Sleep(100);
}while(th.count == 10);

}
}