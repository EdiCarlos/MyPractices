using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExamples
{
    class FindInArray
    {
        int[] i = new int[] { 10, 20, 30, 40, 50 };
        public void showFound()
        {
            int j = Array.Find<int>(i, FindInArrary);
            Console.WriteLine(j);
        }
        public static bool FindInArrary(int i)
        {
            if (i == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
