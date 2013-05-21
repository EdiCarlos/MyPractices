using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCalc
{
    interface ICalculator
    {
        int Add(int num1, int num2);
        int Sub(int num1, int num2);
        int Div(int num1, int num2);
        int Mul(int num1, int num2);
    }
}
