using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EvalServiceHost
{
    class Exe
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:8080/ServiceModel/Service");

            ServiceHost serviceHost = new ServiceHost(typeof(CalculatorService), uri);
            try
            {
                serviceHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                System.ServiceModel.Description.ServiceMetadataBehavior serviceMetadataBehavior = new System.ServiceModel.Description.ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;
                serviceHost.Description.Behaviors.Add(serviceMetadataBehavior);

                serviceHost.Open();
                Console.WriteLine("This service is ready");
                Console.WriteLine("Press <Enter> to terminate");
                Console.WriteLine();
                Console.ReadLine();
                serviceHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Error occured");
                serviceHost.Abort();
            }
        }
    }
}
