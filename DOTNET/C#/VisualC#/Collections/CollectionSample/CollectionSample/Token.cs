using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CollectionSample
{
    
    class Token : IEnumerable
    {
        string[] elements;
        public Token(string source, char [] delimiter)
        {
            elements = source.Split(delimiter);
        }

        public IEnumerator GetEnumerator()
        {
            return new TokenNumber(this);
        }
        class TokenNumber : IEnumerator
        {
            int position = -1;
       
            #region IEnumerator Members
            Token t;
            public TokenNumber(Token t)
            {
                this.t = t;
            }
            public object Current
            {
                get { return t.elements[position]; }
            }

            public bool MoveNext()
            {
                if (position < t.elements.Length - 1)
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
