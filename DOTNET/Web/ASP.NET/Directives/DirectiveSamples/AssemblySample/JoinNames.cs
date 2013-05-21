using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssemblySample
{
    public class JoinNames
    {
        public  static string FirstName, LastName;
         static JoinNames()
        {
            FirstName = "Arif";
            LastName = "Khan";
        }
        public  static string GetName()
        {
            return FirstName + " " + LastName;
        }
    }
}