using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();
            int num1 = 100;
            int num2 = 15;
            Console.WriteLine("Addition {0}, {1} = {2}", num1, num2, client.Addition(num1, num2));
        }
    }
}
