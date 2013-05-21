using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    public class Sample1
    {
        interface IPrimitive
        {
            string Method1();
            string Method2();
        }
        class Primitive1 : IPrimitive
        {
            #region IPrimitive Members

            public string Method1()
            {
                return "P1:M1";
            }

            public string Method2()
            {
                return "P1:M2";
            }

            #endregion
        }
        class Primitive2 : IPrimitive
        {
            #region IPrimitive Members

            public string Method1()
            {
                return "P2:M1";
            }

            public string Method2()
            {
                return "P2:M2";
            }

            #endregion
        }

        class Algorithm
        {
            public string TemplateMethod(IPrimitive primitive)
            {
                return primitive.Method1() + " " + primitive.Method2();
            }
        }
        public class Client
        {
            public static void RunMain()
            {
                Algorithm r = new Algorithm();
                Console.WriteLine(r.TemplateMethod(new Primitive1()));
                Console.WriteLine(r.TemplateMethod(new Primitive2()));
            }
        }

    }
}
