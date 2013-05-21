using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class EvalServiceBehavior : IEvalService
    {
        List<Eval> evals = new List<Eval>();
        
        public void SubmitEval(Eval eval)
        {
            eval.Id = Guid.NewGuid().ToString();
            evals.Add(eval);
        }

        public List<Eval> GetEvals()
        {
            return evals;
        }

        public void RemoveEval(string Id)
        {
            evals.Remove(evals.Find(e => e.Id.Equals(Id)));
        }
    }
}
