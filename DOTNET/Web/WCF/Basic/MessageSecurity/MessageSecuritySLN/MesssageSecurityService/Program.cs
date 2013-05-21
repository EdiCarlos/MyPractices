using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MesssageSecurityService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                Console.WriteLine("Service is running on this address {0} ", host.BaseAddresses[0]);
                host.Open();
               
                Console.WriteLine("Press enter to close");
                Console.ReadLine();
            }
        }
    }
}
