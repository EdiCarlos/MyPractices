using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace httpSample
{
    [ServiceContract]
    public interface IPeople
    {
        [OperationContract]
        void StoredPerson(StorePersonMessage personMessage);
    }
}
