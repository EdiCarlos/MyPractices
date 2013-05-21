using System;
using System.ServiceModel;

namespace basicService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Addition(int num1, int num2);
        [OperationContract]
        double Subtraction(int num1, int num2);
        [OperationContract]
        double Multiplication(int num1, int num2);
        [OperationContract]
        double Division(int num1, int num2);
    }
    public class Calculator : ICalculator
    {

        public double Addition(int num1, int num2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            double result = num1 + num2;
            return result;
        }

        public double Subtraction(int num1, int num2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            return num1 - num2;
        }

        public double Multiplication(int num1, int num2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            return num1 * num2;
        }

        public double Division(int num1, int num2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            double result = num1 / num2;
            return result;
        }
    }
    public class service
    {
        public static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Calculator)))
            {
                host.Open();
                Console.WriteLine("Service started {0}", host.BaseAddresses[0]);
                Console.WriteLine("press enter to terminate");
                Console.WriteLine();
                Console.ReadLine();
            
            }
        }
    }
}