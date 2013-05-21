using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace httpSample
{
    [MessageContract]
    public class StorePersonMessage
    {
        [MessageHeader]
        public UpdateBehavior UpdateBehavior;
        [MessageBodyMember]
        public Person Person;
    }
}