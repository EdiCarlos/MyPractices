using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Token t = new Token("this is my string", new char[] { ' ', '-' });
            //foreach (string str in t)
            //{
            //    Console.WriteLine(str);
            //}
            //System.Collections.IEnumerator ie = t.GetEnumerator();
            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Current);
            //}
            string[] name = { "arif", "khan", "hasan" };
            //System.Collections.IEnumerator ie = new MyEnumerator(name);
            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Current);
            //}
            IMyGetEnum<string> myget = new IMyGetEnum<string>(name);
            //foreach (string str in myget)
            //{
            //    Console.WriteLine(str);
            //}
            IEnumerator<string> ie = myget.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
           
        }
    }
    class IMyGetEnum<T> : IEnumerable<T>
    {
        T[] t;
        public IMyGetEnum(T[] t)
        {
            this.t = t;
        }
        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < t.Length; i++)
            {
                yield return t[i];
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new RunEnum<T>(this);
        }

        #endregion
        class RunEnum<T> : IEnumerator<T>
        {
            int position = -1;
            IMyGetEnum<T> myenum;
            public RunEnum(IMyGetEnum<T> t)
            {
                myenum = t;
            }


            #region IEnumerator<T> Members

            public T Current
            {
                get { return myenum.t[position]; }
            }

            #endregion

            #region IDisposable Members

            public void Dispose()
            {
               
            }

            #endregion

            #region IEnumerator Members

            object System.Collections.IEnumerator.Current
            {
                get { return myenum.t[position]; }
            }

            public bool MoveNext()
            {
                if (position <= myenum.t.Length)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }

            #endregion
        }
    }
}
