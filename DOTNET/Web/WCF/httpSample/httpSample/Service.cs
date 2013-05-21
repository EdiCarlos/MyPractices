using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace httpSample
{
    [ServiceBehavior]
    public class Service : IPeople
    {
        [OperationBehavior]
        public void StoredPerson(StorePersonMessage personMessage)
        {
            personMessage.UpdateBehavior.UpdateConcurrency = EUpdateConcurrency.UpdateIfModified;
            //StorePersonMessage prMessage = new StorePersonMessage();
            //prMessage.UpdateBehavior.UpdateConcurrency = personMessage.UpdateBehavior.UpdateConcurrency
            
            Person pr = new Person();
            pr.Id = personMessage.Person.Id;
            pr.FirstName = personMessage.Person.FirstName;
            pr.LastName = personMessage.Person.LastName;
            pr.MiddleName = personMessage.Person.MiddleName;
            pr.DateOfBirth = personMessage.Person.DateOfBirth;
        }
    }
}