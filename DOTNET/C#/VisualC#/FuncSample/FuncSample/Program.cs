using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncSample
{
    class Program
    {
        public delegate string DName(string fname, string lname, string mname);
        static void Main(string[] args)
        {
            //DName dname = ShowFullName;
            //Console.WriteLine(dname("Arif", "khan", "hasan"));
            //Func<string, string, string, string> fShowName = ShowFullName;
            //Console.WriteLine("Using Func " + fShowName("Arif", "Khan", "Hasan"));
            //Func<string> sName = ShowName;
            //Console.WriteLine(sName());
            SimpleFunc.UseSimpleFunc();
            AnonymousFunc.UseAnonymousFunc();
            LambdaFunc.UseLambdaFunc();
        }
        public static string ShowFullName(string fname, string lname, string mname)
        {
            return fname + " " + lname + " " + mname;
        }
        public static string ShowName()
        {
            return "Arif";
        }
    }
}
