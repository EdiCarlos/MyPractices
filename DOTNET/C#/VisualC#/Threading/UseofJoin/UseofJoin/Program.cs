using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace UseofJoin
{
    class Program
    {
        delegate void RunWorkDel();

        static void Main(string[] args)
        {
            //ThreadPool pool;
            exe e = new exe();
            Thread[] t1 = new Thread[10];
            for (int i = 0; i < t1.GetUpperBound(0) - 1; i++)
            {
                t1[i] = new Thread(e.Work);
                t1[i].IsBackground = true;
                t1[i].Name = i.ToString();
                t1[i].Start();
            }

            ThreadStart start = new ThreadStart(e.Work);
            ThreadStart start2 = new ThreadStart(e.Work2);

            AssignWorkToOneThread(t1, start);
            AssignWorkToOneThread(t1, start2);
            for (int i = 0; i < t1.GetUpperBound(0); i++)
            {
                if (t1[i] != null)
                {
                    t1[i].Join();
                }
            }
        }

        private static int CheckIfAlive(Thread[] t1)
        {
            int j = -1;
            int i = 0;
            bool count = true;
            do
            {
                if (t1[i] != null)
                {
                    if (!t1[i].IsAlive)
                    {
                        j = i;
                        break;
                    }
                }
                if (t1.GetUpperBound(0).Equals(i))
                {
                    i = 0;
                }
                else
                {
                    i++;
                }

            } while (count);
            return j;
        }
        private static int AssignWorkToOneThread(Thread[] t1, ThreadStart start)
        {
            bool check = true;
            while (check)
            {
                int id = CheckIfAlive(t1);
                if (id != -1)
                {
                    Console.WriteLine("Thread id " + id);
                    t1[id] = new Thread(start);
                    t1[id].Name = id.ToString();
                    t1[id].IsBackground = true;
                    t1[id].Start();
                    check = false;
                    return id;
                }
            }
            return 0;
        }
    }
    class exe
    {
        public exe()
        {
        }
        public void Work()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Thread {0} = {1}", Thread.CurrentThread.Name, i);
            }
        }
        public void Work2()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Thread {0} = {1}", Thread.CurrentThread.Name, i);
            }
        }
    }
}
