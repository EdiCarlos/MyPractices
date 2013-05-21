using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace SimpleAjax2
{
    // NOTE: If you change the interface name "ISService" here, you must also update the reference to "ISService" in Web.config.
    [ServiceContract(Namespace="SimpleAjax2")]
    public interface ISService
    {
        [OperationContract]
        [WebGet]
        string DoWork(string str);
    }
}
