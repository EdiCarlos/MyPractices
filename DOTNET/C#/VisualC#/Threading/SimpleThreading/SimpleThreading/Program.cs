using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParameterizedThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //thread method with parameters
            //Thread th = new Thread(MyParameterziedThread);
            //th.Start("Hello parameterized Thread");
            //Thread th1 = new Thread(new ThreadStart(Th1));
            //th1.Start();
            //Thread th2 = new Thread(new ThreadStart(CountDown));
            //th2.Start();
            //th1.Join();

            //MyThread th = new MyThread("MYThread");
            //Thread td = new Thread(th.Run);
            //td.Start();
            //do
            //{
            //    Console.Write(".");
            //    Thread.Sleep(100);
            //} while (th.count != 50);
            //Console.WriteLine("Terminating main thread");
            Console.WriteLine("Main Thread Starting");
            //MainThread mn1 = new MainThread("Child 1");
            //MainThread mn2 = new MainThread("Child 2");
            //MainThread mn3 = new MainThread("Child 3");

            //MainThread1 mn1 = new MainThread1("Th1", 100);
            //MainThread1 mn2 = new MainThread1("Th2", 50);

            //do
            //{
            //    Thread.Sleep(100);
            //} while (mn1.th.IsAlive | mn2.th.IsAlive);
            //AnonymousDelegate.ClassMn();
            //Console.WriteLine("Main Thread Ending");
            //usemeve.ShowMyEve();


            //Console.WriteLine(Thread.CurrentThread.GetHashCode());
            //RunAddParams.RMain();
            //do
            //{
            //    Console.WriteLine("Thread is sleeping");
            //    Thread.Sleep(100);
            //} while (RunAddParams.isAlive());


            AbortThread th = new AbortThread();
            th.RMain();
        }
        public static void MyParameterziedThread(object ob)
        {
            Console.WriteLine("this is the object form Thread : " +ob);
        }
        public static void Th1()
        {
            Console.WriteLine("Th1");
        }
        public static void CountDown()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class MainThread
    {
        public int count;
        public Thread th;
        public string name;
        public MainThread(string thname)
        {
            name = thname;
            count = 0;
            th = new Thread(Run);
            th.Start();
        }
        public void Run()
        {
            Console.WriteLine(name + " Starting");
            do
            {
                Console.WriteLine(count);
                count++;
                Thread.Sleep(100);
            } while (count < 100);
            Console.WriteLine(name + " Terminating");
        }
    }
    class MainThread1
    {
        public int count;
        public Thread th;
        public MainThread1(string name, int num)
        {
            count = 0;
            th = new Thread(Run);
            th.Name = name;
            th.Start(num);
        }
        public void Run(object num1)
        {
            Console.WriteLine(th.Name + "Starting with count " + count);
            do
            {
                Console.WriteLine(count);
                count++;
                Thread.Sleep(100);
            } while (count < (int)num1);
            Console.WriteLine(th.Name + " Terminatin thread Count " + count);
        }
    }
    class MyThread
    {
        string threadname;
        public int count;
        public MyThread(string threadName)
        {
            count = 0;
            threadname = threadName;
        }
        public void Run()
        {
            Console.WriteLine(threadname + " Starting ");
            do
            {
                Thread.Sleep(100);
                Console.WriteLine(count);
                count++;
            } while (count < 100);
            Console.WriteLine(threadname + " Terminating");
        }
    }
}
