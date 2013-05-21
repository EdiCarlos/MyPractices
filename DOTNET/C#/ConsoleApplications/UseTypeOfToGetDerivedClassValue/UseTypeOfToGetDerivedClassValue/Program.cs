using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace UseTypeOfToGetDerivedClassValue
{
    class BaseClass
    {
        public int A = 10, B = 20;
        
    }
    class DerivedA : BaseClass
    {
        public int C = 30;
        public int PropertyC
        {
            get { return C; }
            set { C = value; }
        }
    }
    class DerviedB : BaseClass
    {
        public int C = 30;

    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedA();
            b.GetType().GetProperty("PropertyC").SetValue(b, 100, null);
            Console.WriteLine(((DerivedA)b).C);
        }
    }
}
