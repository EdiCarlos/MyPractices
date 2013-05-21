using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program1
    {
        public void Operation1()
        {
            Console.WriteLine("Program 1");
        }
    }
    class Program2
    {
        public void Operation2()
        {
            Console.WriteLine("Program 2");
        }
    }
    class Program3
    {
        public void Operation3()
        {
            Console.WriteLine("Program 3");
        }
    }
    class FacadeClass
    {
        private Program1 prog1;
        private Program2 prog2;
        private Program3 prog3;
        public FacadeClass()
        {
            prog1 = new Program1();
            prog2 = new Program2();
            prog3 = new Program3();
        }
        public void Execution1()
        {
            Console.WriteLine("Calling Execution 1");
            prog1.Operation1();
            prog2.Operation2();
        }
        public void Execution2()
        {
            Console.WriteLine("Calling Execution 2");
            prog2.Operation2();
            prog3.Operation3();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FacadeClass facade = new FacadeClass();
            facade.Execution1();
            facade.Execution2();
        }
    }
}
