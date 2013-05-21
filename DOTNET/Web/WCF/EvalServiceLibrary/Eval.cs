using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EvalServiceLibrary
{
    [DataContract]
    public class Eval
    {
        [DataMember]
        public string Id;
        [DataMember]
        public string Submitter;
        [DataMember]
        public string Comments;
        [DataMember]
        public DateTime TimeSubmitted;
    }
}
