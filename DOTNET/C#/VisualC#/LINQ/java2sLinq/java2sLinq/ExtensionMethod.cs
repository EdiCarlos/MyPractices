using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace java2sLinq
{
    static class ExtensionMethod
    {
        public static string AddString(this string str, string str2)
        {
            return str + " " + str2;
        }
        public static int Plus(this int i)
        {
            return ++i;
        }
        public static void ShowPlus()
        {
            int i = 10;
            Console.WriteLine(i.Plus());
        }
        public static void ShowAddString()
        {
            string fname = "Arif";
            string lname = "Khan";
            Console.WriteLine(fname.AddString(lname));
        }
    }
}
