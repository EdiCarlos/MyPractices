using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleAjax2
{
    // NOTE: If you change the class name "SService" here, you must also update the reference to "SService" in Web.config.
    public class SService : ISService
    {
        
        public string DoWork(string str)
        {
            return "Hello world";
        }

    }
}
