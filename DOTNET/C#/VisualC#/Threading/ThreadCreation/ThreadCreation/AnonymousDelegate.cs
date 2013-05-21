using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class AnonymousDelegate
    {
        public AnonymousDelegate()
        {
        }
        public static void AnonymousMain()
        {
            Thread[] thread = new Thread[5];
            for (int i = 0; i < thread.Length; i++)
			{
                thread[i] = new Thread(delegate() { Console.WriteLine("anonymous delegate " + i); });
            thread[i].Start();
			}
        }
    }
}
