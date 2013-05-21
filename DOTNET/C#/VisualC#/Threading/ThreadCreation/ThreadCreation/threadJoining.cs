using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class threadJoining
    {
        public static void threadProc()
        {
            int i = 0;
            do
            {
                Console.Write(i);
                i++;
            } while (i < 100);
        }
        public static void MainThreadJoining()
        {
            
            Thread[] th = new Thread[1000];
            for (int i = 0; i < 1000; i++)
            {
                th[i] = new Thread(threadProc);
                th[i].IsBackground = true;
                th[i].Start();
                th[i].Join();
            }
            Console.WriteLine("Calling to join to wait for threadproc method to end");
           
        }
    }
}
