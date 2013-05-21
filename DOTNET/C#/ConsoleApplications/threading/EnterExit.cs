using System;
using System.Threading;

class EnterExit
{
public int result = 0;
public void nonCritical()
{
Console.WriteLine("Entered into non critical section");
Console.WriteLine("Entered  thread " + Thread.CurrentThread.GetHashCode());
for(int i = 1; i < 5; i++)
{
Console.WriteLine("nResult = "+ result++  + " ThreadID " + Thread.CurrentThread.GetHashCode()); 
Thread.Sleep(1000);
}
Console.WriteLine("Exiting Thread " + Thread.CurrentThread.GetHashCode());
Console.WriteLine("Exiting non Critical section");
}
public void CriticalSection()
{
Monitor.Enter(this);
Console.WriteLine("Entered Thread " + Thread.CurrentThread.GetHashCode());
for(int i = 0; i < 5; i++)
{
Console.WriteLine("cResult = " + result++ + "Thread Id " + Thread.CurrentThread.GetHashCode());
Thread.Sleep(1000);
}
Console.WriteLine("Exiting thread  " + Thread.CurrentThread.GetHashCode()); 	
Monitor.Exit(this);

}
}
class exe
{
public static void Main()
{
EnterExit e = new EnterExit();
/*Thread nt1 = new Thread(new ThreadStart(e.nonCritical));
nt1.Start();
Thread nt2 = new Thread(new ThreadStart(e.nonCritical));
nt2.Start();
*/
Thread nt3 = new Thread(new ThreadStart(e.CriticalSection));
nt3.Start();
Thread nt4 = new Thread(new ThreadStart(e.CriticalSection));
nt4.Start();
}
}