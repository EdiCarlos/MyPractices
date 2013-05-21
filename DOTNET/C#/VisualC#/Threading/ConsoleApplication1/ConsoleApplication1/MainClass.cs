using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadBackground
{
    class MainClass
    {
        private int Runs = 0;
        public void CountUp()
        {
            while (Runs < 10)
            {
                Interlocked.Increment(ref Runs);
                Console.WriteLine(Thread.CurrentThread.Name + "  Runs " + Runs);
                Thread.Sleep(100);
            }
        }
        public void RunThreads()
        {
            Thread t1 = new Thread(new ThreadStart(CountUp));
            t1.Name = "Run1";
            Thread t2 = new Thread(new ThreadStart(CountUp));
            t2.Name = "Run2";
            t1.Start();
            t2.Start();
        }
    }
}
