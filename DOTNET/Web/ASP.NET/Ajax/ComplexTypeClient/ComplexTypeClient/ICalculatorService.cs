using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ComplexTypeClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract(Namespace="ComplexTypeClientAjax")]
    public interface ICalculatorService
    {
        [OperationContract]
        MathResult DoMath(double n1, double n2);
    }

    [DataContract]
    public class MathResult
    {
        [DataMember]
        public double sum;

        [DataMember]
        public double difference;

        [DataMember]
        public double product;

        [DataMember]
        public double quotient;
    }
}
