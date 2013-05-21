using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JSonSampleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetNameService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetNameService.svc or GetNameService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior]
    public class GetNameService : IGetNameService
    {
        [OperationBehavior]
        public FullName GetFullName(string firstName)
        {
            return new FullName() { FirstName = "Arif", LastName = "Khan", MiddleName = "Hasan" };
        }
    }
}
