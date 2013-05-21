using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace SimpleAjax1
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
    [ServiceContract(Namespace="SimpleAjax1")]
    public interface IService1
    {
        [OperationContract]
        [WebGet]
        string GetData(int value);
    }
}
