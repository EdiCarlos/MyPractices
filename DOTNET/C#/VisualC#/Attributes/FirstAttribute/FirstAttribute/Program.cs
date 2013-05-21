#define TRACE_ON

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace FirstAttribute
{
    

    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    class Author : System.Attribute
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double version;

        public double Version
        {
            get { return version; }
            set { version = value; }
        }
        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }

        
    }
    class Trace
    {
        
        public static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.Method();
            //B b = new B();
            //b.OldMethod();
            //Trace.Msg("Now in Main Method");
            //Console.WriteLine("Done.");
            Calculator.calc cl = new calc(100, 200);
            Console.WriteLine(cl.Addition(100, 200));
        }
    }
    [Author("Arif Khan", Version = 1.1)]
    class exe
    {
        public exe()
        {

        }
       
    }
    [System.Obsolete("Use class B")]
    class A
    {
        public void Method()
        {
            Console.WriteLine("Class A Method");
        }
    }
    class B
    {
        [System.Obsolete("Use NewMethod", true)]
        public void OldMethod()
        {
            Console.WriteLine("Class B OldMethod");
        }
        public void NewMethod()
        {
            Console.WriteLine("Class B NewMethod");
        }
    }

}
