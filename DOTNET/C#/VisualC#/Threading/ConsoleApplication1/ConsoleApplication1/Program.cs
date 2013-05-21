using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ThreadBackground
{
    struct Ports
    {
        public static int StartPort;
        public int EndPort;
        public IPAddress ip;
    }
    class Program
    {
        public delegate void CountDel();
        static void Main(string[] args)
        {
            Ports port = new Ports();
            Ports.StartPort = 1;
            port.EndPort = 1000;
            port.ip = IPAddress.Parse("127.0.0.1");

            Thread[] th = new Thread[100];
            MoniterThisClass monitor = new MoniterThisClass();
            Program prog = new Program();

            for (int i = 0; i < 100; i++)
            {
                th[i] = new Thread(new ParameterizedThreadStart(prog.ShowPorts));
                th[i].Name = "Thread " + i;
                th[i].IsBackground = true;
                th[i].Start(port);
            }
            for (int i = 0; i < 100; i++)
            {
                th[i].Join();
            }

            //ThreadPool.QueueUserWorkItem(new WaitCallback(ShowPorts), port);
            //Thread th1 = Thread.CurrentThread;
            //th1.Join();
            //Console.WriteLine("Exiting Main Thread");


            //MainClass cl = new MainClass();
            //cl.RunThreads();
        }
        public void ShowPorts(object obj)
        {
            Ports p = (Ports)obj;

            TcpClient cl;
            do
            {
                cl = new TcpClient();


                try
                {
                    lock (this)
                    {
                        Interlocked.Increment(ref Ports.StartPort);
                        cl.Connect(p.ip, Ports.StartPort);
                    
                    }
                    if (cl.Connected)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " Scanned " + Ports.StartPort.ToString());
                        cl.Close();
                    }

                }
                catch
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Scanned " + Ports.StartPort.ToString());
                       
                }

            } while (Ports.StartPort < p.EndPort);
            //  Monitor.Exit(this);
        }
    }
}
