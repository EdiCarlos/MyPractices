using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionSample
{
   public class BL
    {
       public static bool CheckStringIsEmpty(string message)
       {
           return String.IsNullOrEmpty(message) == true ? true : false;
       }
       public static void RunAction(Action<string> ac, string message)
       {
           ac(message);
       }
       public static void RunEmptyAction(Action<string> ac)
       {
           ac("Hello anonymous");
       }
    }
}
