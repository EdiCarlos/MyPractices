using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EvalServiceHost
{
    [ServiceContract]
    interface ICalculator
    {
        [OperationContract]
        double Addition(double n1, double n2);
        [OperationContract]
        double Subtraction(double n1, double n2);
        [OperationContract]
        double Mulitplication(double n1, double n2);
        [OperationContract]
        double Division(double n1, double n2);
    }
}
