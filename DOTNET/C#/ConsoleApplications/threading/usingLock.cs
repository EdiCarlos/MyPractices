using System;
using System.Threading;

namespace mylock
{
public class exe
{
public static void Main()
{
my2ndclass cl = new my2ndclass();
Thread[] thread = new Thread[10];
for(int i = 0; i < 10; i++)
{
thread[i] = new Thread(new ThreadStart(cl.mythread));
thread[i].Start();
}
}
}
class my2ndclass
{
private int counter;
public void mythread()
{
IntCounter();
}
private void IntCounter()
{
lock(this)
{
counter++;
}
}
}
}