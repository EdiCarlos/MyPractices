using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            int i;
            //Console.WriteLine("Name " + str + " age " + i);
            RFunction(ref str);
            OFunction(out i);
            Console.WriteLine("Name " + str + " age " + i);
            
        }

        private static void OFunction(out int i)
        {
            i = 0;
        }

        private static void RFunction(ref string str)
        {
            str = "khan";
        }
    }
}
