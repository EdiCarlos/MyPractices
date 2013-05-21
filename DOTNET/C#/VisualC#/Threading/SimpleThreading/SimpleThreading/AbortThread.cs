using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParameterizedThreading
{
    class AbortThread
    {
        public static int count = 0;
        public AbortThread()
        {

        }
        public void RMain()
        {
            MyThreadClass cl = new MyThreadClass();
            ThreadStart start = new ThreadStart(cl.MyTh);
            Thread th = new Thread(start);
            th.Start();
            try
            {
                if (count == 0)
                {
                    th.Abort();
                }
            }
            catch (ThreadAbortException exe)
            {
                Console.WriteLine(exe.Message);
            }
            Console.WriteLine(th.IsAlive);
        }
    }
    class MyThreadClass
    {
        public void MyTh()
        {
            AbortThread.count = 1;           
        }
    }
}
