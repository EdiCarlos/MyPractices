using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TracePointExampe
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            int result = Addition(i, j);
        }

        private static int Addition(int i, int j)
        {
            return (i + j);
        }
    }
}
