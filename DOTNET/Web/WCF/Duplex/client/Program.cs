using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace client
{
    class CalculatorCallBack : ICalculatorCallback
    {
        #region ICalculatorCallback Members

        public void Result(double n)
        {
            Console.WriteLine("My Result {0}", n.ToString());
        }

        public void Equation(string str)
        {
            Console.WriteLine("My Equation {0}", str);
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CalculatorCallBack());
            CalculatorClient client = new CalculatorClient(instanceContext);
            client.AddTo(100.00D);
            client.SubtractTo(50.0D);
            client.MultipleTo(17.0D);
            client.DivideTo(2.0D);
            client.Clear();
            Console.WriteLine("Press <Enter> to close");
            Console.ReadLine();

            client.Close();

        }
    }
}
