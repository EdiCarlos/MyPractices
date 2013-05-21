using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExplicitAndImplicit
{
    public interface IABC
    {
        void X();
        void Y();
        void Z();
    }
    public interface IX
    {
        void X();
    }
    class A : IABC, IX
    {
        void IABC.X()
        {
            Console.WriteLine("Explicit Class A Method X");
        }

        void IABC.Y()
        {
            Console.WriteLine("Explicit Class A Method Y");
        }

        void IABC.Z()
        {
            Console.WriteLine("Explicit Class A Method Z");
        }

        void IX.X()
        {
            throw new NotImplementedException();
        }
    }
    class B : IABC, IX
    {
        public void X()
        {
            Console.WriteLine("Implicit Class B Method X");
        }

        public void Y()
        {
            Console.WriteLine("Implicit Class B Method Y");
        }

        public void Z()
        {
            Console.WriteLine("Implicit Class B Method Z");
        }

        void IX.X()
        {
            Console.WriteLine("Method X is already implemented so class X will be implement explicitly");
        }
    }
    class C : A, IX
    {
        void IX.X()
        {
            Console.WriteLine("Class C explicit implementation of method X");
        }
    }
    class Program
    {
        static void RunABCInterfaceSample()
        {
            A a = new A();

            B b = new B();
            b.X();
            b.Y();
            b.Z();

            IABC abc = new A();
            abc.X();
            abc.Y();
            abc.Z();

            IABC xyx = new B();
            xyx.X();
            xyx.Y();
            xyx.Z();

            C c = new C();
            ((IX)c).X();
        }
        static void Main(string[] args)
        {
            
        }
    }
}
