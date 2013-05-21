using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace httpSample
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember(IsRequired = false)]
        public string MiddleName;
        [DataMember()]
        public DateTime DateOfBirth;
    }
}
