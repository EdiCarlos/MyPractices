using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class MultiThreadCreation
    {
        int i = 0;
            
        public Thread thread;
        public MultiThreadCreation(string name)
        {
            thread = new Thread(new ThreadStart(Run));
            thread.Name = name;
            thread.Start();
        }
        public void Run()
        {
            Console.WriteLine("Thread run Starting " + thread.Name);
            do
            {
                Console.WriteLine("Thread " + thread.Name + "  count is " + i);
                i++;
            } while (i <= 10);
            Console.WriteLine("terminating Thread " + thread.Name);
        }
    }

}
