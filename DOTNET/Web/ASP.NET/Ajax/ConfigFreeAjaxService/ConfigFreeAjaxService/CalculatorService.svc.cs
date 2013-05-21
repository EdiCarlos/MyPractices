using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConfigFreeAjaxService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalculatorService.svc or CalculatorService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior]
    public class CalculatorService : ICalculatorService
    {
        [OperationBehavior]
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        [OperationBehavior]
        public double Subtraction(double n1, double n2)
        {
            return n1 - n2;
        }
        [OperationBehavior]
        public double Division(double n1, double n2)
        {
            return n1 / n2;
        }
        [OperationBehavior]
        public double Multiplication(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}
