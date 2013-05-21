using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Linq.Expressions;

namespace ExtensionMethods
{
    public class CaseSensitiveComparer : IComparer<string>
    {

        
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }

    }
    public class Program
    {
        static void Main()
        {
            string[] words = { "a", "A", "e", "G", "d", "E", "F" };
            var sortedWords = words.OrderBy(w => w, new CaseSensitiveComparer());
            foreach (var item in sortedWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
