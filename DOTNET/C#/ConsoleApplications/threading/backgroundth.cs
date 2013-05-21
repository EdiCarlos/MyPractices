using System;
using System.Threading;

class myclass
{
[STAThread]
public static void Main()
{
Thread [] th = new Thread[10];
Console.WriteLine("Starting first five threads in background");
for(int i = 0; i < th.Length - 5; i++)
{
th[i] = new Thread(new ThreadStart(Docount));
th[i].Start();
th[i].IsBackground = true;
}
Console.WriteLine("Starting second threads");
for(int i = th.Length - 5; i < th.Length; i++)
{
th[i] = new Thread(new ThreadStart(Docount));
th[i].Start();
}
for(int i = 0; i < 10; i++)
{
while(th[i].IsAlive)
{
Console.WriteLine("{0} is alive", i);
}
}
}

public static int count = 0;
public static  void Docount()
{
for(int i = 0; i < 100; i++)
{
Console.Write(i + " ");
count++;
}
}
}