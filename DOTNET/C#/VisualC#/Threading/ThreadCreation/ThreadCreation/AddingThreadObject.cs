using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class AddParam
    {
        public int num1;
        public int num2;
        public AddParam(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }
    class AddingThreadObject
    {

        public AddingThreadObject()
        {

        }
        public static void Add(object data)
        {
            if (data is AddParam)
            {
                Console.WriteLine("Thread name in gethashcode " + Thread.CurrentThread.GetHashCode());
                AddParam a = data as AddParam;
                Console.WriteLine("{0} + {1} = {2} ", a.num1, a.num2, a.num1 + a.num2);
            }
        }
        public static int MyMain()
        {
            Console.WriteLine("main thread name "+ Thread.CurrentThread.GetHashCode());
            AddParam p = new AddParam(10, 10);
            Thread thread = new Thread(new ParameterizedThreadStart(Add));
            thread.Start(p);
            return 0;
        }
    }
}
