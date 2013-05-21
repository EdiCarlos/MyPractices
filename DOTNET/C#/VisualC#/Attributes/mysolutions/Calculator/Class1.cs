using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class calc
    {
        int num1, num2;
        public calc()
        {

        }
        public calc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        
        }

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        
        }
    }
}
