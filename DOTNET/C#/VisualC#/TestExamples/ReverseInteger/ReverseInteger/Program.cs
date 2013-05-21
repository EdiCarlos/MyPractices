using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123456789;
            string stri = i.ToString();
            string temp = String.Empty;
            for (int j = stri.Length - 1; j > -1; j--)
            {
                
                temp += stri[j];    
            }
            Console.WriteLine(Convert.ToInt32(temp));
        }
    }
}
