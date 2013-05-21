using System;
using System.Threading;

class exe
{
public static void Main()
{
Console.WriteLine(Thread.CurrentThread.Name);

Thread th =new Thread(new ThreadStart(counter));
Thread th1 = new Thread(new ThreadStart(counter1));
th.Priority = ThreadPriority.Lowest;
th1.Priority = ThreadPriority.Highest;
th.Start();
th1.Start();

}

public static void counter()
{
Console.WriteLine("Enter Counter1");
for(int i = 0; i < 50; i++)
{
Console.Write(i + " " );
if(i == 10)
{
Thread.Sleep(1000);
}
}
Console.WriteLine();
Console.WriteLine("Exiting counter1");
}
public static void counter1()
{
Console.WriteLine("Enter Counter2");
for(int i = 0; i < 100; i++)
{
Console.Write(i + " " );
if(i == 70)
{
Thread.Sleep(500);
}
}
Console.WriteLine();
Console.WriteLine("Exiting counter2");

}
}