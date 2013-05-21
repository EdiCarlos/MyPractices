using System;
using System.Threading;

class exe
{
public static void Mythread()
{
Thread th = Thread.CurrentThread;
//th.IsBackground = false;
Console.WriteLine("Name : {0}", th.Name);
Console.WriteLine("IsBack ground : {0}", th.IsBackground);
Console.WriteLine("Is Alive : {0} ", th.IsAlive);
Console.WriteLine("Priority : {0}", th.Priority);
for(int i=0;i < 20000; i++)
{
Console.WriteLine("{0} value of I is {1} ", th.Name, i);
Console.Write(i * i);
} 
}

public static void Main()
{
Console.WriteLine("Enter main thread");
Thread th = new Thread(new ThreadStart(Mythread));
th.Priority = ThreadPriority.Highest;
th.IsBackground= true;
th.Name = "BackGround Thread";
th.Start();

Thread th1 = new Thread(new ThreadStart(Mythread));
th1.Name = "ForeGround thread";
th1.Start();
Thread.Sleep(1000 * 5);
Console.WriteLine("Exiting main Thread");
}
}