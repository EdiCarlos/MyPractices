using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //ShowEvenNumber(numbers);
            int [] num = MakeTolist(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            foreach (var i in num)
            {
                Console.WriteLine(i                 );
            }
        }

        private static int[] MakeTolist(params int [] numbers)
        {
            return (from num in numbers where (num % 2) == 0 select num).ToArray<int>();
        }
        public static void ShowEvenNumber(int[] numbers)
        {
            IEnumerable<int> evenNumber = from num in numbers
                                          where (num % 2) == 0
                                          select num;
            Console.WriteLine("Count = " + evenNumber.Count<int>());
            foreach (var v in evenNumber)
            {
                Console.WriteLine(v);
            }
        }
    }
}
