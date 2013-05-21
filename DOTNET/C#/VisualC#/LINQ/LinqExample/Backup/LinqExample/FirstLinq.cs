using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExample
{
    class FirstLinq
    {

        public void ShowGreater()
        {
            int[] score = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] city = { "mumbai", "delhi", "kolkatta", "Banglore" };
            IEnumerable<int> scorequery = 
                from sc in score 
                where sc > 3 
                orderby sc descending 
                select sc;

            int highest = (from sc in score select sc).Max();
            IEnumerable<IGrouping<char, string>> c = from ct in city group ct by ct[0];
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
           foreach (var item in scorequery)
           {
               Console.WriteLine(item);
           }
           Console.WriteLine("Begin of reverse");
           
           Console.WriteLine("highest " + highest);
        }
    }
}
