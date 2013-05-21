using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MesssageSecurityService
{
    public class CalculatorService : MesssageSecurityService.ICalculatorService
    {
        public double Add(double n1, double n2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            return n1 + n2;
        }
        public double Mulitply(double n1, double n2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            return n1 * n2;
        }
        public double Subtract(double n1, double n2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            return n1 - n2;
        }
        public double Division(double n1, double n2)
        {
            Console.WriteLine("Called by {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name);
            return n1 / n2;
        }
    }
}
