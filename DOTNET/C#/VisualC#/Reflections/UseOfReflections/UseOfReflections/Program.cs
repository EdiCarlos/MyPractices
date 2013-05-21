using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace UseOfReflections
{
    class myClass
    {
        string fname, lname, mname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Mname
        {
            get { return mname; }
            set { mname = value; }
        }
        public myClass()
        {
            fname = "Arif";
            lname = "khan";
            mname = "BanneHasan";
        }
        public string GetFullName()
        {
            return fname + " " + lname + " " +mname;
        }
        public void GetName(string fname, string mname, string lname)
        {
            Console.WriteLine(fname + " " + lname + " " + mname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass cls = new myClass();
            Type tp = cls.GetType();
            foreach (PropertyInfo info in tp.GetProperties())
            {
                if (info.CanRead)
                {
                    Console.WriteLine(info.Name + "  " + cls.GetType().GetProperty(info.Name).GetValue(cls, null));
                }
            }
            object classInstance = Activator.CreateInstance(tp, true);
            MethodInfo fullName = tp.GetMethod("GetFullName");
            Console.WriteLine(fullName.Invoke(classInstance, null));
            object[] paramMethod = new object[]{"Aarif", "Khan", "Hasan"};
           MethodInfo getName =  tp.GetMethod("GetName");
           getName.Invoke(classInstance, paramMethod);
            //Console.WriteLine(GetAssemblyPath("MyCommanApp.config"));
            
        }
        public static string GetAssemblyPath(string ConfigFileName)
        {
            string AssemblyPath = string.Empty;
            try
            {
                AssemblyPath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                AssemblyPath = AssemblyPath.Replace(@"file:///", "");
                AssemblyPath = AssemblyPath.Substring(0, AssemblyPath.LastIndexOf(@"/"));

                if (ConfigFileName.Trim().Equals(string.Empty))
                {
                    AssemblyPath += @"/CommonSettings.config";
                }
                else
                {
                    AssemblyPath += @"/" + ConfigFileName.Trim();
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
            return AssemblyPath;
        }

    }
}
