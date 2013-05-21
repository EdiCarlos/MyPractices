using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DualHttpSample;
using System.Threading;

namespace DualHttpSampleClient
{
    public class CallbackHandler : IDualCalculatorServiceCallback
    {
        public void Result(double result1)
        {
            Console.WriteLine("Result {0} ", result1);
        }

        public void Equation(string eqn)
        {
            Console.WriteLine("Equation {0} ", eqn);
        }
    }
    public class NameCallBackHandler : IDualNameServiceCallback
    {
        AutoResetEvent eve = null;
        public NameCallBackHandler()
        {
            eve = new AutoResetEvent(false);
        }
        public AutoResetEvent ResetEvent
        {
            get { return eve; }
        }
        public string FirstName()
        {
            Console.WriteLine("Enter Your FirstName");
            string firstName = Console.ReadLine();
            return "Arif ";
        }

        public string MiddleName()
        {
            Console.WriteLine("Enter Your MiddleName");
            string middleName = Console.ReadLine();

            return middleName; 
        }

        public string LastName()
        {
            Console.WriteLine("Enter Your LastName");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public void FullName(string fullName1)
        {
            Console.WriteLine("Your callback fullname is {0}", fullName1);
            eve.Set();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCallBackHandler nameHandler = new NameCallBackHandler();
            InstanceContext instanceContextName = new InstanceContext(nameHandler);

            DualNameServiceClient nameClient = new DualNameServiceClient(instanceContextName);
            Console.WriteLine("Displaying name ");

            nameClient.ShowName();

            WaitHandle.WaitAll(new AutoResetEvent[]{nameHandler.ResetEvent});

            Console.WriteLine("Exiting main....");
            
            //InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            //DualCalculatorServiceClient client = new DualCalculatorServiceClient(instanceContext);
            //Console.WriteLine("Press <ENTER> to terminate client once the output is displayed.");
            //Console.WriteLine();

            //double value = 100.00D;
            
            //client.AddTo(value);

            //value = 50.00D;
            //client.SubtractFrom(value);

            //client.Clear();
            //Console.ReadLine();
            //client.Close();

        }
    }
}
