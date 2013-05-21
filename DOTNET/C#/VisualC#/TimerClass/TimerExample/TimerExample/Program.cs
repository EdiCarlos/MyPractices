using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;

namespace TimerExample
{
    class Program
    {
        static string isIdle = string.Empty;

        static void Main(string[] args)
        {
            //Thread th = new Thread(new ThreadStart(Runtimer));
            //th.Name = "Mythread";
            //th.Start();
            ////Thread.Sleep(1000);

            //Thread t = Thread.CurrentThread;
            //t.Join();
            //Program prog = new Program();
            //System.Timers.Timer timeOut = new System.Timers.Timer(5000);
            //timeOut.Enabled = true;
            ////timeOut.Elapsed += new ElapsedEventHandler(prog.time_Elapsed_out);
            //timeOut.Start();

            //System.Timers.Timer time = new System.Timers.Timer(1000);
            //time.Elapsed += new ElapsedEventHandler(prog.time_Elapsed_1);
            ////time.Interval = 1000;
            //time.Enabled = true;
            //time.Start();
            //Thread.Sleep(10000);
            object obj = "False";
            MyClass cl = new MyClass(obj);
            Thread.Sleep(5000);
            cl.Time.Stop();
        }

        int sec = 0;
        public void time_Elapsed_1(object sender, ElapsedEventArgs e)
        {

            while (sec == 5000)
            {
                Console.WriteLine("Job Stop");
                sec = 1000;
                break;
            }
            Console.WriteLine(e.SignalTime.Ticks);
            sec += 1000;
        }

        static void Runtimer()
        {

            System.Timers.Timer time = new System.Timers.Timer(100);
            time.Enabled = true;
            time.Elapsed += new ElapsedEventHandler(time_Elapsed);
            time.Start();
        }

        static void time_Elapsed(object sender, ElapsedEventArgs e)
        {

            Console.WriteLine("Timer " + e.SignalTime.Second);

            if (e.SignalTime.Second == 20)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Thread.CurrentThread.Abort();
            }
        }




    }
    class MyClass
    {
        object sen;
        System.Timers.Timer time = null;
        public System.Timers.Timer Time
        {
            get { return time; }
        }
        public object Sen
        {
            get { return sen; }
            set { sen = value; }
        }
        public MyClass(object sender)
        {
            Sen = sender;
            time = new System.Timers.Timer();
            time.Interval = 10;
            time.Elapsed += new ElapsedEventHandler(time_Elapsed);
            time.Start();
        }
        void time_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (sen.ToString() == "True")
            {
                Console.WriteLine("Job Stop");
                ((System.Timers.Timer)sender).Stop();
            }
            Console.Write(sen + ";");
        }
    }
}
