using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ImperativeClient
{
    [ServiceContract(Namespace = "http://imperativesample")]
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

    class Program
    {
        static void Main(string[] args)
        {
            ReliableSessionBindingElement reliable = new ReliableSessionBindingElement();
            reliable.Ordered = true;

            HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
            httpTransport.AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous;
            httpTransport.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;

            CustomBinding custBinding = new CustomBinding(reliable, httpTransport);

            EndpointAddress endPointAddress = new EndpointAddress("http://localhost:8000/ImperativeSample/CalculatorService");

            ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>(custBinding, endPointAddress);

            ICalculator calc = channelFactory.CreateChannel();
            double result = calc.Add(10, 10);
            Console.WriteLine(result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
