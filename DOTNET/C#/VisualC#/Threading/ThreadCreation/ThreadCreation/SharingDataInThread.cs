using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class SharingDataInThread
    {
        public static void MainSharedThread()
        {
            SharedClass cl = new SharedClass();
            cl.message = "hello there";
            var th = new Thread(new ThreadStart(cl.Run));
             th.Start();
             //Thread.Sleep(100);
             th.Join();
             //Console.ReadLine();
            Console.WriteLine(cl.reply);
     

            //ThreadPriority priority = ThreadPriority.Lowest;
     
            //Thread current = Thread.CurrentThread;
            // current.Priority = priority;
        }
    }
    class SharedClass
    {
        public string message, reply;
        public SharedClass()
        {

        }
        public void Run()
        {
            Console.WriteLine(message);
            reply = "right back";
        }
    }
}
