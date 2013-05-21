using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //IncrementOnce inc = new IncrementOnce(1);
            //++inc;
            //Console.WriteLine(inc.ToString());
            //++inc;
            //Console.WriteLine(inc.ToString());
            BinaryNumeral binary = 10;
            BinaryNumeral dbin = (BinaryNumeral)100.00f;
            Console.WriteLine((string)binary);
            
        }
    }
    struct BinaryNumeral
    {
        int value;
        float fvalue;
        static public implicit operator BinaryNumeral(int it)
        {
            BinaryNumeral binary = new BinaryNumeral();
            binary.value = it;
            return binary;
        }
        static public explicit operator BinaryNumeral(float it)
        {
            BinaryNumeral binary = new BinaryNumeral();
            binary.fvalue = it;
            return binary;
        }
        static public explicit operator int(BinaryNumeral binary)
        {
            return binary.value;
        }
        static public explicit operator string(BinaryNumeral binary)
        {
            return binary.value.ToString();
        }
        public override string ToString()
        {
            return new BinaryNumeral().value.ToString();
        }
    }
    class RomanNumeral
    {

    }
    class IncrementOnce
    {
        public IncrementOnce(int num)
        {
            this.num = num;
        }
        int num = 0;
        static bool val = false;
        public static IncrementOnce operator ++(IncrementOnce inc)
        {
            if (val == false)
            {
                inc.num++;
                val = true;
            }
            return inc;
        }
        public override string ToString()
        {
            return num.ToString();
        }
    }
}
