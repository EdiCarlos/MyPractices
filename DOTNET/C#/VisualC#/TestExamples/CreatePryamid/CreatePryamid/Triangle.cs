﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatePryamid
{
    class Triangle
    {
        public void ShowTriangle()
        {
            Console.WriteLine(" Enter the value ");
            int k = int.Parse(Console.ReadLine());
            int n = k - 1;
            int x = 2 * (k - 1) + 1;
            for (int p = 0; p <= n; p++)
            {
                for (int j = k - 1; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= (x - 2 * (k - 1)); i++)
                {
                    if ((i % 2 == 1 && i == 1) || (i % 2 == 1 && i == (x - 2 * (k - 1))) || (i % 2 == 1 && p == n))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                k--;
            }
            Console.ReadLine();
        }
    }
}
class Tri
{

}
