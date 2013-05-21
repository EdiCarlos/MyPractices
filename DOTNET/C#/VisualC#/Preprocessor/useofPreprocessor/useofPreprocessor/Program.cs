#pragma warning disable 0219
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace useofPreprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("normar line . 1");
#line hidden
            Console.WriteLine("Hidden line");

#line default
            Console.WriteLine("Default line");
            int i = 0;
        }
    }
}
