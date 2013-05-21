using System;
using System.Text;
using System.Threading;
using System.IO;

class readwrite
{
public readwrite(string str)
{
Thread th = Thread.CurrentThread;
th.Name = str;
Console.WriteLine(th.Name);
}
public void writefile(object obj)
{
Monitor.Enter(this);

FileStream fs = new FileStream(@"d:\temp\myfile.txt", FileMode.Append, FileAccess.Write);
StreamWriter sw = new StreamWriter(fs);
string str = String.Empty;
Console.WriteLine("write to file");
str = Console.ReadLine();
sw.WriteLine(str);
sw.Close();
Monitor.Exit(this);
}
public void readfile(object obj)
{
Monitor.Enter(this);
FileStream fs = File.OpenRead(@"d:\temp\myfile.txt");
byte [] b = new byte[1024];
UTF8Encoding temp = new UTF8Encoding(true);
while(fs.Read(b, 0, b.Length) > 0)
{
Console.WriteLine(temp.GetString(b));
}
Monitor.Exit(this);
Thread.Sleep(400);
}
}
class exe
{
static void Main()
{
readwrite read = new readwrite("mythread");
ConsoleKeyInfo cki;
Console.WriteLine("press escape to exit");
Console.WriteLine("press any to begin writting file");
cki = Console.ReadKey();

while(cki.Key != ConsoleKey.Escape) 
{
ThreadPool.QueueUserWorkItem(read.writefile, "string");
Thread.Sleep(1000);
ThreadPool.QueueUserWorkItem(read.readfile, "string");
Console.WriteLine("presss any key to continue press escape to cancel");
cki = Console.ReadKey();
}

}
}