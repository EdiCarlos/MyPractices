using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadBackground
{
    class DoCountClass
    {
        public static void DoCount(Object stateinfo)
        {
            for (int i = 0; i < 10000; i++)
            {
                   Console.WriteLine("{0} reached {1}", Thread.CurrentThread.Name, i);
            }
        }
    }
}
