using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace service
{
    // NOTE: If you change the interface name "Iservice" here, you must also update the reference to "Iservice" in Web.config.
    [ServiceContract(Namespace="http://service", CallbackContract=typeof(ICallBackCalucator))]
    public interface ICalculator
    {
        [OperationContract(IsOneWay = true)]
        void Clear();

        [OperationContract(IsOneWay=true)]
        void AddTo(double n);
[OperationContract(IsOneWay=true)]
       void SubtractTo(double n);
        [OperationContract(IsOneWay=true)]
        void MultipleTo(double n);
        [OperationContract(IsOneWay=true)]
        void DivideTo(double n);
    }
    public interface ICallBackCalucator
    {
        [OperationContract(IsOneWay=true)]
        void Result(double n);
        [OperationContract(IsOneWay=true)]
        void Equation(string str);
    }
}
