using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            OvrIndexer ovr = new OvrIndexer(10);
            ovr[0] = "A";
            ovr[1] = "B";
            ovr[2] = "C";
            ovr[3] = "D";
            Console.WriteLine(ovr[0] + " " + ovr[1] + " " + ovr[2]);
        }
    }
    public class OvrIndexer
    {
        string[] arr1;
        public OvrIndexer(int size)
        {
            arr1 = new string[size];
        }
        //    public string OvrIndexer[int pos]
        //{
        //}
        public string this[int pos]
        {
            get { return arr1[pos]; }
            set { arr1[pos] = value; }
        }
    }
}
