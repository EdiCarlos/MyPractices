using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckingPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass ba = new BaseClass("Arif");

            BaseClass.MySecondClass mySecond = ba.GetMySecondClass();
            mySecond.MyMethod(); 
        }
    }
   //public class DerivedClass : BaseClass
   //{
   //    //public DerivedClass()
   //    //{
   //    //    Console.WriteLine("Devrived Class Instantiated");
   //    //}
   //}
}
