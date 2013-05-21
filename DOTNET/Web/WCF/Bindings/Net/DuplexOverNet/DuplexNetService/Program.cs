using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DuplexNetService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Open();
                Console.WriteLine("Service started on {0}", host.BaseAddresses[0]);
                Console.WriteLine("Press enter to close service");
                Console.ReadLine();
            }
        }
    }
}
