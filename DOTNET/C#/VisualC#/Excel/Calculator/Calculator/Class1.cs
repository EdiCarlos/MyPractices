using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calculation
    {
        public static double Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public static double Sub(int num1, int num2)
        {
            return (num1 - num2);
        }
        public static double Mul(int num1, int num2)
        {
            return (num1 * num2);
        }
        public static double Div(int num1, int num2)
        {
            return (num1 / num2);
        }
    }
}
