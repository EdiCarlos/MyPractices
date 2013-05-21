#define Track

using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalAttr attr = new ConditionalAttr();
            attr.Track();
            attr.Trace();
            IfDebugs debug = new IfDebugs();
            debug.RunCur();
        }
    }
    class ConditionalAttr
    {
        [method: System.Diagnostics.Conditional("Track")]
        public void Track()
        {
            Console.WriteLine("Track is defined");
        }
        [method: System.Diagnostics.Conditional("Trace")]
        public void Trace()
        {
            Console.WriteLine("Trace is defined");
        }
    }
    class IfDebugs
    {
        public IfDebugs()
        {
        }
        [System.Diagnostics.Conditional("Debug")]
        public void RunCur()
        {
            Console.WriteLine("Execute only if debug is defined");
        }
    }
}