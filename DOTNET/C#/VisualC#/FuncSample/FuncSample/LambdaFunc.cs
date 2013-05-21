using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncSample
{
    class LambdaFunc
    {
        public static void UseLambdaFunc()
        {
            Func<string, string, string> lambdaFunc = (s, b) => { return s + " " + b; };
            Console.WriteLine(lambdaFunc("A", "B"));
        }
    }
}
