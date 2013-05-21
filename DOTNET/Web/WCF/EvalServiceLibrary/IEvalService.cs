using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EvalServiceLibrary
{
    [ServiceContract]
    interface IEvalService
    {
        [OperationContract]
        void SubmitEval(Eval eval);
        [OperationContract]
          List<Eval> GetEvals();
        [OperationContract]
          void RemoveEval(string Id);
    }
}
