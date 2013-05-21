using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputeHashMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SummaryEntityModelContainer container = new SummaryEntityModelContainer();

            //Console.WriteLine(System.Text.Encoding.ASCII.GetString(container.DC_DocHeader.First().TStamp));
            IQueryable<byte[]> query = container.DC_DocHeader.Select(e => e.TStamp);
            foreach (byte[] bt in query)
            {
                if (bt != null)
                {
                    Console.WriteLine(System.Text.Encoding.ASCII.GetString(bt));
                }
                
            }
        }
    }
}
