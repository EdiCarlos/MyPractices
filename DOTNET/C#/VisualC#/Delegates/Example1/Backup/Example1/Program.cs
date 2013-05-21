using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1
{
    public delegate void Mydel();
    abstract class myclass
    {
        public abstract void Addition(int num1, int num2);
    }
    class Program : myclass
    {
        public override void Addition(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.Addition(10, 20);
            exe e = new exe();
            e.Divide(5, 0);
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
            catch(Exception exy)
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
