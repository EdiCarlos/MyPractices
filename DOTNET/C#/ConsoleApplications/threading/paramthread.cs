using System;
using System.Threading;

class MyThread
{
public int count;
public Thread th;
public MyThread(string name, int num)
{
count = 0;
th = new Thread(new ParameterizedThreadStart(this.run));
th.Name = name;
th.Start(num);
}
void run(object num)
{
Console.WriteLine("Enter run Thread");
do
{
Thread.Sleep(400);
Console.WriteLine("Thread Name " + th.Name + " Count " + count);
count++;
}while(count <= (int) num);
Console.WriteLine("Exiting run thread");
}
}
class exe
{
public static void Main()
{
Console.WriteLine("Entering Main thread");
MyThread mt1 = new MyThread("Child 1", 5);
MyThread mt2 = new MyThread("Child 2", 3);
do
{
Thread.Sleep(100);
}while(mt1.th.IsAlive | mt2.th.IsAlive);
Console.WriteLine("exiting Main thread");
}
}