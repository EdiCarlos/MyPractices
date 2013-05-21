using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvalFristExample
{
    [System.ServiceModel.ServiceBehavior(InstanceContextMode=System.ServiceModel.InstanceContextMode.Single)]
    class EvalService : IEvalService
    {
        List<EvalMembers> list = new List<EvalMembers>();

        #region IEvalService Members
        
        public void Submit(EvalMembers eval)
        {
            eval.Id = Guid.NewGuid().ToString();
            list.Add(eval);
        }

        public List<EvalMembers> GetEval()
        {
            return list;
        }

        public void Remove(string ID)
        {
            list.Remove(list.Find(e => e.Id == ID));
        }
        
        #endregion
    }
}
