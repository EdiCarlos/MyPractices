using System;
using System.Threading;

namespace myname
{
class exe
{
public static void Main()
{
calculation calc = new calculation();
Console.WriteLine("Result = {0}.", calc.result(234).ToString());
Console.WriteLine("Result = {0}.", calc.result(55).ToString());

}
}
class calculation
{
Random rnd;

double basenum, firstnum, secondnum, thirdnum;
AutoResetEvent [] autoevent;
ManualResetEvent mevent;
public calculation()
{
autoevent = new AutoResetEvent[]{new AutoResetEvent(false), new AutoResetEvent(false), new AutoResetEvent(false)};
mevent = new ManualResetEvent(false);
}
public void CalculateBase(object stateinfo)
{
basenum = rnd.NextDouble();


mevent.Set();

}
public void CalculateFirst(object stateinfo)
{
double precalc = rnd.NextDouble();

mevent.WaitOne();
firstnum = precalc * basenum * rnd.NextDouble();
autoevent[0].Set();
}
public void CalculateSecond()
{
double precalc = rnd.NextDouble();
mevent.WaitOne();
secondnum = precalc * basenum * rnd.NextDouble();
autoevent[1].Set();
}
public void CalculateThird()
{
double precalc = rnd.NextDouble();
mevent.WaitOne();
thirdnum = precalc * basenum * rnd.NextDouble();
autoevent[1].Set();

}
public int result(int seed)
{
rnd = new Random(seed);
ThreadPool.QueueUserWorkItem(new WaitCallBack(CalculateBase));
ThreadPool.QueueUserWorkItem(new WaitCallBack(CalculateFirst));
ThreadPool.QueueUserWorkItem(new WaitCallBack(CalculateSecond));
ThreadPool.QueueUserWorkItem(new WaitCallBack(CalculateThird));

WaitHandle.WaitAll(autoevent);
mevent.Reset();

return firstnum + secondnum + thirdnum;


}
}
}
