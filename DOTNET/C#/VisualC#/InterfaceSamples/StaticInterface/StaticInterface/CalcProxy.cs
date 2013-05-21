using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticInterface
{
    class CalcProxy : ICalc
    {
        Calc calc;
        public int Addition(int num1, int num2)
        {
            GetInstance(); 
            return calc.Addition(num1, num2);
        }

        public int Subtraction(int num1, int num2)
        {
            GetInstance();
            return calc.Subtraction(num1, num2);
        }

        private void GetInstance()
        {
            if (calc == null)
            {
                calc = new Calc();
            }
        }
    }
}
