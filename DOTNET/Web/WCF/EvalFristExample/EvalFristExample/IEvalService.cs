using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvalFristExample
{
    [System.ServiceModel.ServiceContract]
   interface IEvalService
    {
        [System.ServiceModel.OperationContract]
       void Submit(EvalMembers eval);
        [System.ServiceModel.OperationContract]
        List<EvalMembers> GetEval();
        [System.ServiceModel.OperationContract]
        void Remove(string ID);
    }
}
