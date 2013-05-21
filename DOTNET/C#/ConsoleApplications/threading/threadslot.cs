using System;
using System.Threading;

class Program
{
public static void Main()
{
Thread[] th = new Thread[4];
for(int i = 0; i < th.Length; i++)
{
th[i] = new Thread(new ThreadStart(Slot.SlotTest));
th[i].Start();
}
}
}
class Slot
{
static Random rnd;
static LocalDataStoreSlot slt;
static Slot()
{
rnd = new Random();
slt = Thread.AllocateDataSlot();
}
public static void SlotTest()
{
Thread.SetData(slt, rnd.Next(0, 200));

Console.WriteLine("Data in Thread {0} 's data slot {1, 3}", AppDomain.GetCurrentThreadId().ToString(), Thread.GetData(slt).ToString());
Thread.Sleep(1000);
Console.WriteLine("Data in Thread {0} 's data slot {1, 3}", AppDomain.GetCurrentThreadId().ToString(), Thread.GetData(slt).ToString());

}
}