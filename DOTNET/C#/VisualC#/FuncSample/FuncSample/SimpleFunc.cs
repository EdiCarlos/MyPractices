using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncSample
{
    class SimpleFunc
    {
        public static void UseSimpleFunc()
        {
            Func<string, string, string> FAddString;
            FAddString = AddString;
            Console.WriteLine(FAddString("A", "B"));
        }
        public static string AddString(string firstStr, string secondStr)
        {
            return firstStr + " " + secondStr;
        }
    }
}
