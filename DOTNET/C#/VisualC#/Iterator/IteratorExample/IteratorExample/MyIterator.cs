using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorExample
{
    class MyIterator
    {
        public System.Collections.IEnumerator GetEnumerator()
        {
            yield return "arif";
            yield return "Khan";
            yield return "hasan";
            yield return (1).ToString();


        }
    }
}
