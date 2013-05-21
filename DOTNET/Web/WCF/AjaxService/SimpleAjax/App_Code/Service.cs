using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

[ServiceContract(Namespace = "SimpleService")]
public class Service
{
    // Add [WebGet] attribute to use HTTP GET
    [OperationContract]
    [WebGet]
    public string DoWork()
    {
        // Add your operation implementation here
        return "hello world";
    }

    // Add more operations here and mark them with [OperationContract]
}
