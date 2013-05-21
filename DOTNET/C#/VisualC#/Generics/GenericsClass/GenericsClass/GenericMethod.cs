using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsClass
{
   
    class GenericMethod
    {
        public void Swap<T>(ref T lhs,ref T rhs) where T : IComparable<T>
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
