using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

// NOTE: If you change the interface name "IService2" here, you must also update the reference to "IService2" in Web.config.
[ServiceContract(Namespace="SimpleService2")]
public interface IService2
{
    [OperationContract]
    [System.ServiceModel.Web.WebGet]
    string DoWork(string str);
}
