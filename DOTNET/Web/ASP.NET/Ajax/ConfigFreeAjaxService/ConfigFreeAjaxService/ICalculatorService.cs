using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConfigFreeAjaxService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract(Namespace="ConfigFreeAjaxService")]
    public interface ICalculatorService
    {
        [OperationContract(Name="Add")]
        double Add(double n1, double n2);
        [OperationContract(Name = "Subtract")]
        double Subtraction(double n1, double n2);
        [OperationContract(Name = "Divide")]
        double Division(double n1, double n2);
        [OperationContract(Name = "Multiply")]
        double Multiplication(double n1, double n2);
    }
}
