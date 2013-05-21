using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomAuthenticationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace="Custom")]
    public interface ICustomAuthenticationService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<string> GetClaims();

        [OperationContract]
        FullName GetFullName(string name);
        // TODO: Add your service operations here
    }
    [DataContract]
    public class FullName
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }

    }
}
