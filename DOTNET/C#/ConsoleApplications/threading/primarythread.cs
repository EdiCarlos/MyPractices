using System;
using System.Threading;
class exe
{
public static void Main()
{
Thread primary = Thread.CurrentThread;
primary.Name = "The primary thread";

Console.WriteLine("Name of current appdomain: {0} ", Thread.GetDomain().FriendlyName);
Console.WriteLine("ID of current context: {0} " ,  Thread.CurrentContext.ContextID);
Console.WriteLine("Thread Name : {0}", primary.Name);
Console.WriteLine("Has Thread started ? : {0}", primary.IsAlive);
Console.WriteLine("Priority Level : {0}", primary.Priority);
Console.WriteLine("Thread state : {0}", primary.ThreadState);
}
}