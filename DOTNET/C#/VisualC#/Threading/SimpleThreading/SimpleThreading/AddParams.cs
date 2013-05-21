using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParameterizedThreading
{
    class AddParams
    {
        public int a;
        public int b;
        public AddParams(int num1, int num2)
        {
            a = num1;
            b = num2;
        }

    }
    class RunAddParams
    {
        static Thread th;
        public static void ShowAddParams(object obj)
        {
            if (obj is AddParams)
            {
                AddParams ad = (AddParams)obj;
                Console.WriteLine("{0} + {1} = {2} ", ad.a, ad.b, ad.a + ad.b);
            }
        }
        public static void RMain()
        {
            Console.WriteLine(Thread.CurrentThread.GetHashCode());
            AddParams obj = new AddParams(10, 10);
            th = new Thread(new ParameterizedThreadStart(ShowAddParams));
            th.IsBackground = true;
            th.Start(obj);
        }
        public static bool isAlive()
        {
            return th.IsAlive; 
        }
    }
}
