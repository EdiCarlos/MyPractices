using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParameterizedThreading
{
    class AnonymousDelegate
    {
        public AnonymousDelegate()
        {

        }

        public static void ClassMn()
        {
              int ThreadCount = 5;
              Thread[] th1 = new Thread[ThreadCount];
            //Thread th = new Thread(delegate() { Console.WriteLine("Hello world"); });
              for (int i = 0; i < th1.Length; i++)
              {
                  th1[i] = new Thread(delegate() { Console.WriteLine("delegate " + i); });
              }
            Array.ForEach(th1, delegate(Thread t) { t.Start(); });
        }
        
    }
}
