using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GenericsClass
{
    class MyGenerics<T>
    {
        T vr;
        T[] m;
        List<T> list;
        public MyGenerics(T str)
        {
            vr = str;
            list = new List<T>();
        }
        public MyGenerics(T[] str)
        {
            m = str;
        }
        public void Add(T t)
        {
            list.Add(t);
        }
        public void ShowT()
        {
            Console.WriteLine(vr);
        }
        public void IterateT()
        {
            IEnumerator ie = list.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
        }
    }
    abstract class Action<T>
    {
        public abstract void Swap();
        public abstract void Show();
    }
    class BaseClass<T> : Action<T>
    {
        T t1;
        T t2;
        public BaseClass(T t1, T t2)
        {
            this.t1 = t1;
            this.t2 = t2;
        }

        public override void Swap()
        {
            T temp;
            temp = t1;
            t1 = t2;
            t2 = temp;
        }
        public override void Show()
        {
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
    class DerivedClass<V> where V : class
    {
        public DerivedClass(V vr)
        {
            Console.WriteLine(vr);
        }
    }
    class DerivedClass1<U> 
    {
        public DerivedClass1(U Ur)
        {
            Console.WriteLine(Ur);
        }
    }
}
