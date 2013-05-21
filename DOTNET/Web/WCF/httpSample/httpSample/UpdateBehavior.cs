using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace httpSample
{
   
    public enum EUpdateConcurrency
    {
        UpdateIfModified,
        FailIfModified
    }

    [DataContract]
    public class UpdateBehavior
    {
        [DataMember]
        public EUpdateConcurrency UpdateConcurrency;
    }
}
