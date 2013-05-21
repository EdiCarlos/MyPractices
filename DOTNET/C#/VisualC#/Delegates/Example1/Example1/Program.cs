using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1
{
    public delegate void Mydel();
    public delegate void MyEventHandler();
     
    public delegate int Sum(int num1, int num2);
    abstract class myclass
    {
        public abstract void Addition(int num1, int num2);
    }
    class Program : myclass
    {
        public event MyEventHandler MySomeEvent;
        public override void Addition(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void RaiseMySomeEvent()
        {
            if (MySomeEvent != null)
            {
                MySomeEvent();
            }
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.Addition(10, 20);
            //exe e = new exe();
            //e.Divide(5, 0);
            //Program p = new Program();
            //p.MySomeEvent += p.Foo;
            //p.RaiseMySomeEvent();
            List<int> listInt = new List<int>();
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);
            listInt.Add(5);
            foreach (int i in listInt.Where(e => e >= 2 && e <= 4).Select(e => e))
            {
                Console.WriteLine(i);
            }
            //var queryResult = from li in listInt where li >= 2 && li <= 5 select li;
            //foreach (int i in queryResult)
            //{
            //    Console.WriteLine(i);
            //}
            //Sum s = delegate(int num1, int num2) { return num1 + num2; };
            //Sum s1 = (c, d) => { return c + d; };
            //Console.WriteLine(s1(10, 20));
        //Console.WriteLine(s(10, 20));
        }
        public void Foo()
        {
            Console.WriteLine("My Handler was called"); 
        }
    }
    class exe
    {
        public void Divide(int x, int y)
        {
            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception exy)
            {
            }
            catch
            {
                Console.WriteLine("Divide by zero exception occcured");
                //Console.WriteLine(exy.Message);
            }
        }
    }
}
