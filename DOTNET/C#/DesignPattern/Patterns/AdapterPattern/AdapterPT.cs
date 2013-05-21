using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    class AdapterPT
    {
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }
    interface IAdaptor
    {
        string Request(int i);
    }
    class Adaptor : AdapterPT, IAdaptor
    {
        public string Request(int i)
        {
            return "Rough Estimate is " + (int)Math.Round(SpecificRequest(i, 3));
        }
    }
}
