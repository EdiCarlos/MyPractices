using System;
using System.Threading;
class exe
{
public static void Main()
{
Thread th = new Thread(myloop);
th.Start(100);
}
public static void myloop(object var, object obj)
{
for(int i = 0; i < (int)var; i++)
{
Console.WriteLine(i);
Thread.Sleep(100);
}
Console.WriteLine(obj.ToString());
}

}