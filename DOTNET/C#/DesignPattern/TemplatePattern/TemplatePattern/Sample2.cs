using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    class Sample2
    {
        interface IPrimitive
        {
            string Method1();
            string Method2();
        }
        class ClassA : IPrimitive
        {
            #region IPrimitive Members

            public string Method1()
            {
                return "ClassA:Method1";
            }

            public string Method2()
            {
                return "ClassA:Method2";
            }

            #endregion
        }

        class ClassB : IPrimitive
        {
            #region IPrimitive Members

            public string Method1()
            {
                return "ClassB:Method1";
            }

            public string Method2()
            {
                return "ClassB:Method1";
            }

            #endregion
        }

        class TemplatePattern
        {
            public void TemplateMethod(IPrimitive primitive)
            {
                string result = primitive.Method1() + " " + primitive.Method2();
                Console.WriteLine(result);
            }
        }
        public class Client
        {
            public static void RunMain()
            {
                TemplatePattern pattern = new TemplatePattern();
                pattern.TemplateMethod(new ClassA());
                pattern.TemplateMethod(new ClassB());

            }
        }
    }
}
