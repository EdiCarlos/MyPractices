using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadCreation
{
    class ThreadWithArugment
    {
        public Thread thread;
        public int count;
        public ThreadWithArugment(string name, object count)
        {
            this.count = 0;
            thread = new Thread(new ParameterizedThreadStart(Run));
            thread.Name = name;
            thread.Start(count);

        }
        public void Run(object num)
        {
            Console.WriteLine(thread.Name + " starting with count of " + num);
            do
            {
                //Thread.Sleep(500);
                Console.WriteLine("In " + thread.Name + ", count is " + count);
                count++;
            } while (count < (int)num);
            Console.WriteLine("Terminating Thread " + thread.Name);
        }

        public static void RunThreadWithArugment()
        {
            ThreadWithArugment mt1 = new ThreadWithArugment("First", 10);
            ThreadWithArugment mt2 = new ThreadWithArugment("Second", 10);
            do
            {
                Thread.Sleep(100);

            } while (mt1.thread.IsAlive | mt2.thread.IsAlive);
        }
    }
}
