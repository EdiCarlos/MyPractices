using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncSample
{
    class AnonymousFunc
    {
        public static void UseAnonymousFunc()
        {
            Func<string, string, string> FAnonymous;
            FAnonymous = delegate(string a, string b) { return a + " " + b; };
            Console.WriteLine(FAnonymous("A", "B"));
        }
    }
}
