using System;
using System.Threading;

class MyThread
{
public Thread th;
public int count;
public MyThread(string name)
{
count = 0;
th = new Thread(this.run);
th.Name = name;
th.Start();

}
public void run()
{
Console.WriteLine("Entering run thread");
do
{
Thread.Sleep(1000);
Console.WriteLine("In thread Name "+ th.Name + "Count " + count);
count++;
}while(count <= 10);
Console.WriteLine("Exiting run thread");
}
}
class exe
{
public static void Main()
{
Console.WriteLine("Entering main thread");

MyThread m1 = new MyThread("Child 1");
MyThread m2 = new MyThread("Child 2");
MyThread m3 = new MyThread("Child 3");
Thread.Sleep(1000);
Console.WriteLine("Exiting MainThread");
}
}