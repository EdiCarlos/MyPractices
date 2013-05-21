using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDictionary
{
    class Program
    {
        static MyEvent my;
        public static void Method1(int i)
        {
            Console.WriteLine(i);
        }
        public static void Method2(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            //    PropertyClass cl1 = new PropertyClass();
            //    cl1.Event1 += new EventHandler3(Method1);
            //    cl1.Event1 -= new EventHandler3(Method1);
            //    cl1.Event1 += new EventHandler3(Method1);

            //    cl1.RaiseEvent1(10);

            //    cl1.Event2 += new EventHandler4(Method2);
            //    cl1.Event2 += new EventHandler4(Method2);
            //    cl1.Event2 -= new EventHandler4(Method2);

            //    cl1.RaiseEvent2("arif");
            //    PropertyClass1 cl2 = new PropertyClass1();
            //    cl2.Event1 += new EventHandler3(Method1);
            //    cl2.RaiseEvent1(10);

            //    my = new MyEvent();
            //    my.Event1 += new FNamehandler(my_Event1);
            //    Program p = new Program();
            //    p.Load(my);
            //    my.RaiseFNameEvent("Arif", "Khan", "Hasan");

            //GenericDelegate gen = new GenericDelegate();
            //gen.EventUseOf1 += new Mydel<EventHandler1>(gen_EventUseOf1);
            //gen.raiseEvent(10);
            GenericDelegate<EventArgs> gen = new GenericDelegate<EventArgs>();
            gen.GEvent += new GenericDelegate<EventArgs>.Mydel1<EventArgs>(gen_GEvent);
        }

        static void gen_GEvent(object sender, EventArgs t)
        {
            Console.WriteLine(t.GetType());
        }

        static void gen_EventUseOf1(int i)
        {
            Console.WriteLine(i);
        }

        static void my_Event1(string f, string l, string m)
        {
            Console.WriteLine("Frist name " + f + " Last name " + l + " Middle Name " + m);
        }
        void Load(MyEvent m)
        {
            m.Event1 += new FNamehandler(m_Event1);   
        }

        void m_Event1(string f, string l, string m)
        {
            Console.WriteLine("Call from void function");
            Console.WriteLine("Frist name " + f + " Last name " + l + " Middle Name " + m);
            
        }

    }
}
