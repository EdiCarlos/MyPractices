using System;
using System.ServiceModel;

namespace MesssageSecurityService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Division(double n1, double n2);
        [OperationContract]
        double Mulitply(double n1, double n2);
        [OperationContract]
        double Subtract(double n1, double n2);
    }
}
