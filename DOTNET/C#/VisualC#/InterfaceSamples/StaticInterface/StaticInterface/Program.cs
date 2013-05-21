using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc calc1 = new CalcProxy();
            Console.WriteLine(calc1.Addition(10, 10));
        }
    }
}
