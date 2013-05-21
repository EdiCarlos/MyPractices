using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace PortScanning
{
    class Program
    {
        static void Main(string[] args)
        {
            //showport show = new showport("10.63.4.149", "1", "65000");
            //show.runThread();
            ManualResetEvent eve = new ManualResetEvent(true);
            object obj = new object();
            showports show;
            if (args.Length.Equals(0))
            {
                Console.WriteLine("portscan ipaddress startport endport");
            }
            else
            {
                if (args[0] != null && args[1] != null && args[2] != null)
                {
                    show = new showports(args[0], args[1], args[2], eve);
                    show.showp(obj);
                    show.eve.WaitOne();
                    Console.WriteLine("port scanning completed");
                }
                else
                {
                    Console.WriteLine("portscan ipaddress startport endport");
                }
            }
            
            Console.ReadLine();
        }
    }
    class showports
    {
        private int sport, eport;
        private IPAddress ip;
        public ManualResetEvent eve;
        public showports(string ip, string startp, string endp, ManualResetEvent ev)
        {
            this.ip = IPAddress.Parse(ip);
            sport = int.Parse(startp);
            eport = int.Parse(endp);
            eve = ev;
        }
        public void showp(object sender)
        {
            Monitor.Enter(this);
            while (sport < eport)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(connectoThread), sport);
                Thread.Sleep(50);
                Interlocked.Increment(ref sport);
            }
            Monitor.Exit(this);
        }
        public void connectoThread(object sender)
        {
            int sport = (int)sender;
            TcpClient cl = new TcpClient();
            try
            {
                cl.Connect(ip, sport);
                Console.WriteLine(sport.ToString());
            }
            catch
            {
                //Console.Write(" " +sport);
            }
            if (sport.Equals(eport))
            {
                eve.Set();
            }
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
        public void runThread()
        {
            Thread[] th = new Thread[eport];
            for (int i = 0; i < eport; i++)
            {
                th[i] = new Thread(new ThreadStart(showp));
                th[i].IsBackground = true;
                th[i].Start();
                Thread.Sleep(100);
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
}
