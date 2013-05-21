using System;
using System.Threading;

class exe
{
static void Main()
{
myclass my = new myclass();
Thread t1 = new Thread(new ThreadStart(my.readFile));
Thread t2 = new Thread(new ThreadStart(my.writeFile));
Thread t3 = new Thread(new ThreadStart(my.readFile));
Thread t4 = new Thread(new ThreadStart(my.writeFile));

t1.Start();
t4.Start();
t2.Start();
Thread.Sleep(1000);
t3.Start();

}
}
class myclass
{
public string str = "hello world ";
public myclass()
{
}
public void readFile()
{
lock(this)
{

Console.WriteLine(str);
Thread.Sleep(1000);
Console.WriteLine("reader thread is sleeping for 1 second");
}
}
public void writeFile()
{
lock(this)
{
str += " This is another hello world";
Thread.Sleep(1000);
Console.WriteLine("Writer thread is sleeping for 1 second");
}
}
}