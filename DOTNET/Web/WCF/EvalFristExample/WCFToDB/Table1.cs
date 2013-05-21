using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;

namespace WCFToDB
{
    [DataContract]
    class Table1
    {
        
        [DataMember]
        public int ID
        {
            get;
            set;
        }
        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

    }
}
