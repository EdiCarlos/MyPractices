using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSecurityClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient client = new CalculatorServiceClient();
            Console.WriteLine(client.Add(100, 1000));
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
