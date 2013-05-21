using System;
using System.ServiceModel;
namespace DuplexNetService
{
    [ServiceContract(Namespace="http://calculatorService", SessionMode=SessionMode.Allowed, CallbackContract=typeof(CallBackService))]
    public interface ICalculatorService
    {
        [OperationContract(IsOneWay=true)]
        void AddTo(double result);
    }

    public interface CallBackService
    {
        [OperationContract(IsOneWay=true)]
        void DisplayResult(double result);
        [OperationContract(IsOneWay = true)]
        void DisplayMethod(string methodName);
    }
}
