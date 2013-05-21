using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorExample
{
    class IteratorClass 
    {
        string[] fname = { "arif", "Khan", "hasan" };
        public System.Collections.IEnumerator GetEnumerator()
        {
            for (int i = 0; i <= fname.GetUpperBound(0); i++)
            {
                yield return fname[i];
            }
        }
        public System.Collections.IEnumerator GetEnumerator(int start, int end)
        {
            if (end <= fname.GetUpperBound(0) && end >= 0 && start >= 0 && start <= fname.GetUpperBound(0))
            {
                for (int i = start; i <= end; i++)
                {
                    yield return fname[i];
                }
            }
        }
        //public object Current
        //{
        //    get { return fname[0]; }
        //}
        //public bool MoveNext()
        //{
        //    return true;
        //}
        //public void Reset()
        //{
        //}
        
    }
}
