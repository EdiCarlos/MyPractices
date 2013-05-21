using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace TransportService
{
    [ServiceContract(Namespace = "http://Transport")]
    interface ICalculator
    {
        [OperationContract()]
        int Addition(int num1, int num2);
        [OperationContract()]
        int Multiplication(int num1, int num2);
        [OperationContract()]
        int Division(int num1, int num2);
        [OperationContract()]
        int Subtraction(int num1, int num2);

    }

    [ServiceBehavior]
    class Service : ICalculator
    {
        [OperationBehavior]
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        [OperationBehavior]
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        [OperationBehavior]
        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        [OperationBehavior]
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
