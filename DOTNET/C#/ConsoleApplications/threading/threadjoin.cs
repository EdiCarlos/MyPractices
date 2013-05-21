using System;
using System.Threading;

class MainClass
{
public static void Main()
{
Console.WriteLine("Entering Main");
testClass t1 = new testClass("1");
testClass t2 = new testClass("2");
testClass t3  = new testClass("3");
t1.th.Join();
Console.WriteLine("first joined");
t2.th.Join();
Console.WriteLine("second joined");
t3.th.Join();
Console.WriteLine("Third joined");
Console.WriteLine("exiting main");
}
}
class testClass
{
public static int count;
public Thread th;
public testClass(string name)
{
count =0; 
th = new Thread(new ThreadStart(this.run));
th.Name = name;
th.Start();
}
void run()
{
Monitor.Enter(this);
Console.WriteLine(th.Name + "Entering run");
do
{
Thread.Sleep(200);
Console.WriteLine("Thread Name " + th.Name + " counter value " + count++);
}while(count < 30);
Monitor.Exit(this);
Console.WriteLine(th.Name +"Exiting run");
}
}
