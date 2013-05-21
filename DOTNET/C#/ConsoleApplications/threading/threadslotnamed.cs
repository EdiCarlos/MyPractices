using System;
using System.Threading;

class Program
{
public static void Main()
{
Thread [] th = new Thread[4];
for(int i = 0; i < th.Length; i++)
{
th[i] = new Thread(new ThreadStart(Slot.SlotTest));
th[i].Start();
}
}
}
class Slot
{
public static  Random rnd = new Random();

public static void SlotTest()
{
Thread.SetData(Thread.GetNamedDataSlot("random"), rnd.Next(1, 200));
Console.WriteLine("Data in Thread {0}, data slot {1, 3}", AppDomain.GetCurrentThreadId().ToString(), Thread.GetData(Thread.GetNamedDataSlot("random")).ToString());
Thread.Sleep(1000);
Console.WriteLine("Data in Thread {0}, data slot {1, 3}", AppDomain.GetCurrentThreadId().ToString(), Thread.GetData(Thread.GetNamedDataSlot("random")).ToString());

}
}