using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JSonSampleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetNameService" in both code and config file together.
    [ServiceContract(Namespace = "", Name = "GetNameService")]
    public interface IGetNameService
    {
        [OperationContract]
        [WebInvoke(ResponseFormat=WebMessageFormat.Json,
            RequestFormat=WebMessageFormat.Json,
            BodyStyle=WebMessageBodyStyle.WrappedRequest)]
        FullName GetFullName(string firstName);
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
