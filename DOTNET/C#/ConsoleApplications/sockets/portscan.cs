using System;
using System.Data;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

class exe
{
static void Main(string [] args)
{
Console.WriteLine("Entering main thread");
showport show = new showport(args[0], args[1], args[2]);
show.runThread();

Console.WriteLine("Main Thread sleeping");
}
}

class showport
{
private int sport, eport;
private IPAddress ip;
public showport(string ip, string startp, string endp)
{
this.ip = IPAddress.Parse(ip);
sport = int.Parse(startp);
eport = int.Parse(endp);
}
public  void runThread()
{

Thread[] th = new Thread[eport];
for(int i =0; i  < eport; i++)
{
th[i] = new Thread(new ThreadStart(showp));
th[i].IsBackground = true;
th[i].Start();
Thread.Sleep(50);
}
}
public void showp()
{
TcpClient cl = new TcpClient();
try
{
cl.Connect(ip, sport);
Console.Write(sport.ToString());
}
catch
{
Console.Write(".");
}
sport++;
}
}