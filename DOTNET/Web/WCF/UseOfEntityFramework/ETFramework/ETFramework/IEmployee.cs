using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ETFramework
{
    [ServiceContract]
    interface IEmployee
    {
        [OperationContract]
        EmployeeDetails GetEmployeeDetails(int EmployeeID);
    }

    [DataContract]
    public class EmployeeDetails
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string LoginID { get; set; }
        [DataMember]
        public string Address1 { get; set; }
        [DataMember]
        public string Address2 { get; set; }
        [DataMember]
        public string City { get; set; }

    }
}
