using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DuplexNetClient
{
    public class CalculatorCallback : ICalculatorServiceCallback
    {
        public AutoResetEvent ev = new AutoResetEvent(false);
        public void DisplayResult(double result)
        {
            Console.WriteLine("Result from server {0}", result);
        }

        public void DisplayMethod(string methodName)
        {
            Console.WriteLine("Executing Method from server {0}", methodName);
            ev.Set();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           CalculatorCallback call = new CalculatorCallback();
            InstanceContext calcContext = new InstanceContext(call);
            CalculatorServiceClient client = new CalculatorServiceClient(calcContext);
            client.AddTo(100);
            WaitHandle.WaitAll(new AutoResetEvent[]{call.ev});
            Console.WriteLine("Waiting for reply.. from service");
            Console.ReadLine();
        }
    }
}
