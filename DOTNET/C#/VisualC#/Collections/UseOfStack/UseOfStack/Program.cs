using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace UseOfStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack st = new Stack();
            //st.Push("hello");
            //st.Push("World");
            //st.Push("a");
            //st.Push("b");
            ////for (int i = 0; i < 4; i++)
            ////{
            ////    Console.WriteLine(st.Pop());
            ////}
            //foreach (string s in st.ToArray())
            //{
            //    Console.WriteLine(s);
            //}
            //Queue qu = new Queue();
            //qu.Enqueue("arif");
            //qu.Enqueue("khan");
            //qu.Enqueue("hasan");
            //foreach (object obj in qu.ToArray())
            //{
            //    Console.WriteLine(obj);
            //}
            //List<string> li = new List<string>();
            //li.Add("a");
            //li.Add("b");
            //li.Add("c");
            //li.Add("d");
            //foreach (string item in li.ToArray())
            //{
            //    Console.WriteLine(item);
            //}
            //StringBuilder build = new StringBuilder();
            string name = "asdf asdf asdf NAD NAD NAD";
            int length = name.Split(' ').Length;
            int index = 0;
            bool isentered = false;
            for (int i = 0; i < length; i++)
            {
                if (!isentered)
                {
                    index = name.IndexOf("NAD") + 3;
                    isentered = true;
                    Console.WriteLine(index);
                    continue;
                }
                index = name.IndexOf("NAD", index) + 3;
               
                Console.WriteLine(index);

            }

        }
    }
}
