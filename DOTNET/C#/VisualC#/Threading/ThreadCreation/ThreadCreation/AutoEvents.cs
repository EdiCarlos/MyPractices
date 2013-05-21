using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;

namespace ThreadCreation
{
    class AutoEvents
    {
        public static void MainAutoEvents()
        {
            AutoResetEvent autoevent = new AutoResetEvent(false);

            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.Start();
            ThreadPool.QueueUserWorkItem(new WaitCallback(WorkMethod), autoevent);
            ThreadPool.QueueUserWorkItem(new WaitCallback(WorkMethod1), autoevent);
            thread.Join();

            autoevent.WaitOne();
        }
        public static void ThreadMethod()
        {
            Console.WriteLine("ThreadOne, executing ThreadMethod, " +
            "is {0}from the thread pool.",
            Thread.CurrentThread.IsThreadPoolThread ? "" : "not ");
        }
        public static void WorkMethod(object stateinfo)
        {
            Console.WriteLine("ThreadOne, executing ThreadMethod, " +
            "is {0}from the thread pool.",
            Thread.CurrentThread.IsThreadPoolThread ? "" : "not ");

            ((AutoResetEvent)stateinfo).Set();
        }

        public static void WorkMethod1(object stateinfo)
        {
            Console.WriteLine("ThreadOne, executing ThreadMethod, " +
            "is {0}from the thread pool.",
            Thread.CurrentThread.IsThreadPoolThread ? "" : "not ");

            ((AutoResetEvent)stateinfo).Set();
        }
    }
}
