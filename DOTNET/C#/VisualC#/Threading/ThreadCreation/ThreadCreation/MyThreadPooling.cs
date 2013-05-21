using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class MyThreadPooling
    {
        public static void MainMyThreadPooling()
        {
            ThreadPool.QueueUserWorkItem(Go);
            ThreadPool.QueueUserWorkItem(Go, 123);
            Console.ReadLine();
        }
        public static void Go(object data)
        {
            Console.WriteLine("this is go function " + data);
        }
    }
}
