using System;
using System.Threading;

class Program
{
public static void Main()
{
Thread firstthread = new Thread(new ThreadStart(TestMethod));
Thread secondthread = new Thread(new ThreadStart(TestMethod));
}
public static void TestMethod()
{

}
}
