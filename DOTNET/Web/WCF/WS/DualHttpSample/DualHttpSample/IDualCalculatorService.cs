using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DualHttpSample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDualCalculatorService" in both code and config file together.
    [ServiceContract(Namespace="https://mysample/duplex", SessionMode=SessionMode.Required, CallbackContract=typeof(ICallBackCalculator))]
    public interface IDualCalculatorService
    {
        [OperationContract(IsOneWay = true)]
        void Clear();
        [OperationContract(IsOneWay = true)]
        void AddTo(double n1);
        [OperationContract(IsOneWay = true)]
        void SubtractFrom(double n1);
        [OperationContract(IsOneWay = true)]
        void MultiplyBy(double n1);
        [OperationContract(IsOneWay = true)]
        void DivideBy(double n1);
    }

    public interface ICallBackCalculator
    {
        [OperationContract]
        void Result(double result);
        [OperationContract]
        void Equation(string eqn);
    }

}
