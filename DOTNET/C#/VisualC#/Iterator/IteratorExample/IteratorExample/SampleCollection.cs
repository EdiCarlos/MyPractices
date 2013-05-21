using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorExample
{
    public class SampleCollection
    {
        int[] item;
        public SampleCollection()
        {
            item = new int[] { 1, 2, 3, 4, 5, 6 };
        }
        public System.Collections.IEnumerator BuildCollection()
        {
            for (int i = 0; i <= item.GetUpperBound(0); i++)
            {
                yield return item[i];
            }
        }
    }
}
