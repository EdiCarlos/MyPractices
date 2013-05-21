using System;
using System.Threading;

class autoReset
{
[STAThread]
public static void Main()
{
AutoResetEvent auto = new AutoResetEvent(true);
bool state = auto.WaitOne(5000, true);
Console.WriteLine("After Frist Wait : " + state);
state  = auto.WaitOne(10000, true);
Console.WriteLine("After Second Wait : " + state);
}
}