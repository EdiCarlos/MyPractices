using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionSample
{
    class MyEnumerator : System.Collections.IEnumerator
    {
        int position = -1;
        string[] name;
        public MyEnumerator(string [] str)
        {
            name = str;
        }    
        public object Current
        {
            get { return name[position]; }
        }

        public bool MoveNext()
        {
            if (position < name.Length - 1)
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

    }
}
