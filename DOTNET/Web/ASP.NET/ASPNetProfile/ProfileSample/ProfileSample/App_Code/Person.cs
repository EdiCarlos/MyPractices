using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileSample
{
    [Serializable]
    public class Person
    {
        public string FristName { get; set; }
        public string LastName { get; set; }        
        public string EmailAddress { get; set; }
    }
}