using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ImperativeService
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Subtract(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
        [OperationContract]
        double Divide(double n1, double n2);
    }

    class Service : ICalculator
    {

        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
        public static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/servicesamplemodel/service");
            using (ServiceHost host = new ServiceHost(typeof(Service), baseAddress))
            {
                ReliableSessionBindingElement reliableBinding = new ReliableSessionBindingElement();
                reliableBinding.Ordered = true;

                HttpTransportBindingElement httpBindingElement = new HttpTransportBindingElement();
                httpBindingElement.AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous;
                httpBindingElement.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;

                CustomBinding customBinding = new CustomBinding(reliableBinding, httpBindingElement);

                host.AddServiceEndpoint(typeof(ICalculator), customBinding, "");

                host.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

            }
        }

    }
}
