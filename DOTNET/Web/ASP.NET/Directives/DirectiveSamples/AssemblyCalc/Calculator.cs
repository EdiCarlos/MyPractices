using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyCalc
{
   public class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Sub(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int Div(int num1, int num2)
        {
            return (num1 / num2);
        }
        public int Mul(int num1, int num2)
        {
            return (num1 * num2);
        }
    }
}
