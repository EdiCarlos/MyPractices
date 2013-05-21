using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mycalculationClass;
namespace usingmysql
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Myclass cl = new Myclass();
            cl.showValues();
            CalculationClass.Add(10, 10);
            
        }
    }
}
