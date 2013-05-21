using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadBackground
{
    class MoniterThisClass
    {
       
        public static int count = 10;
        public void DoCount()
        {
            lock (this)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("{0} reached {1}", Thread.CurrentThread.Name, i++);
                }
            }
        }
    }
}
