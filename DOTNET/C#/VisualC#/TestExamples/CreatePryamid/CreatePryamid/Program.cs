using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatePryamid
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 10; i > 1; i--)
            //{
            //    for (int k = 1; k < i; k++)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine();
            //}
            Triangle tri = new Triangle();
            tri.ShowTriangle();
        }
    }
}
