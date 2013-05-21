using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterPT adaptee = new AdapterPT();
            Console.WriteLine("Precise reading from specific request");
            Console.WriteLine(adaptee.SpecificRequest(5, 3));

            IAdaptor iAdapt = new Adaptor();
            Console.WriteLine("Moving to new standard");
            Console.WriteLine(iAdapt.Request(3));
        }
    }
}
