using System;
using System.Threading;

class MainClass
{
static void Main()
{
int max, min;
ThreadPool.GetAvailableThreads(out max, out min);
Console.WriteLine("Maximum threads available {0} and Minimum threads available {1}", max, min); 
}
}