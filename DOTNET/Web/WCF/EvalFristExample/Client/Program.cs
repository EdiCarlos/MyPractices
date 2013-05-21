using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client application");
            CalculatorClient client = new CalculatorClient();
            Console.WriteLine("Performing Addition");
            Console.WriteLine(client.Addition(100, 100));
            Console.WriteLine("Performing Multiplication");
            Console.WriteLine(client.Mulitplication(2, 10));
            Console.WriteLine("Press <Enter> to close the application");
            Console.ReadLine();
        }
    }
}
