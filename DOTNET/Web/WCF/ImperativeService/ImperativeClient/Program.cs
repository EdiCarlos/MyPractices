using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ImperativeClient
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

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press <ENTER> after the service has been started.");
            Console.ReadLine();

            ReliableSessionBindingElement reliable = new ReliableSessionBindingElement();
            reliable.Ordered = true;

            HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
            httpTransport.AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous;
            httpTransport.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;

            CustomBinding binding = new CustomBinding(reliable, httpTransport);

            EndpointAddress address = new EndpointAddress("http://localhost:8000/servicesamplemodel/service");

            ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>(binding, address);
            ICalculator calculator = channelFactory.CreateChannel();

            // Call the Add service operation.
            double value1 = 100.00D;
            double value2 = 15.99D;
            double result = calculator.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            // Call the Subtract service operation.
            value1 = 145.00D;
            value2 = 76.54D;
            result = calculator.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            // Call the Multiply service operation.
            value1 = 9.00D;
            value2 = 81.25D;
            result = calculator.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            // Call the Divide service operation.
            value1 = 22.00D;
            value2 = 7.00D;
            result = calculator.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();

            ((IChannelFactory)channelFactory).Close();

        }
    }
}
