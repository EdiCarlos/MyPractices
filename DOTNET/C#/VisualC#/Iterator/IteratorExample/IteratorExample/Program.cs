using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //IteratorClass it = new IteratorClass();
            //foreach (string i in it)
            //{
            //    Console.WriteLine(i);
            //}
            //System.Collections.IEnumerator ie = it.GetEnumerator(0, 2);

            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Current);
            //}
            MyIterator myit = new MyIterator();
            System.Collections.IEnumerator ie = myit.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            foreach (string var in new MyIterator())
            {
                Console.WriteLine(var);
            }

            SampleCollection col = new SampleCollection();
            foreach(int i in col.BuildCollection())
            {
                Console.WriteLine(i);
            }
            //foreach(string var in it.GetEnumerator(0, 3))
            //{
            //    Console.WriteLine(var);
            //}
        }
    }
}
