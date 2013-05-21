using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapTwoInterfaceEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Sub1 sb = new Sub1(shape);
            Sub2 sb2 = new Sub2(shape);
            shape.Draw();
        }
    }
}
