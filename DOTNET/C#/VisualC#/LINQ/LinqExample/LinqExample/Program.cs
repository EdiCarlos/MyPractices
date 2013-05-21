using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstLinq flinq = new FirstLinq();
            //flinq.ShowGreater();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            //int index = (from ar in arr where ar == 5 select ar).FirstOrDefault();
            string[] pdfList = new string[] { "pdf1.pdf", "pdf2.pdf", "pdf3.pdf" };
            int index = pdfList.Select( (string e) => e.CompareTo("pdf2.pdf")).FirstOrDefault();
            
            Console.WriteLine(index);
        }
    }
}
