using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

// NOTE: If you change the class name "Service2" here, you must also update the reference to "Service2" in Web.config.
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Service2 : IService2
{
    #region IService2 Members

    public string DoWork(string str)
    {
        return str;
    }

    #endregion
}
