using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ImperativeSample
{
    [ServiceContract(Namespace="http://imperativesample")]
    interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);

        [OperationContract]
        double Multiply(double n1, double n2);

        [OperationContract]
        double Subtract(double n1, double n2);

        [OperationContract]
        double Divide(double n1, double n2);

    }
    [ServiceBehavior]
    public class CalculatorService : ICalculator
    {
        [OperationBehavior]
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        [OperationBehavior]
        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        [OperationBehavior]
        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        [OperationBehavior]
        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
        public static void Main()
        {
            Uri baseAddress = new Uri("http://localhost:8000/ImperativeSample/CalculatorService");
            using (ServiceHost svcHost = new ServiceHost(typeof(CalculatorService), baseAddress))
            {
                ReliableSessionBindingElement reliable = new ReliableSessionBindingElement();
                reliable.Ordered = true;

                HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
                httpTransport.AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous;
                httpTransport.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;

                CustomBinding custBinding = new CustomBinding(reliable, httpTransport);

                svcHost.AddServiceEndpoint(typeof(ICalculator), custBinding, "");
                svcHost.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

            }
        }
    }
}
