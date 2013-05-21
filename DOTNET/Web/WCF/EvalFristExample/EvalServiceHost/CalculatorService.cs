using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvalServiceHost
{
    class CalculatorService : ICalculator
    {
        #region ICalculator Members

        public double Addition(double n1, double n2)
        {
            double result = n1+ n2;
            Console.WriteLine("Received {0}, {1}", n1, n2);
            Console.WriteLine("Returned {0}", result);
            return result;
        }

        public double Subtraction(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Received {0}, {1}", n1, n2);
            Console.WriteLine("Returned {0}", result);
            return result;
        }

        public double Mulitplication(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("Received {0}, {1}", n1, n2);
            Console.WriteLine("Returned {0}", result);
            return result;
        }

        public double Division(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("Received {0}, {1}", n1, n2);
            Console.WriteLine("Returned {0}", result);
            return result;
        }

        #endregion
    }
}
