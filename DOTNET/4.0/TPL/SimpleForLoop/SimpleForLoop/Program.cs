using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SimpleForLoop
{
    class Program
    {
        static void MultipleMatrixSequential(double[,] matA, double[,] matB, double[,] result)
        {
            int metACols = matA.GetLength(1);
            int metBCols = matB.GetLength(1);
            int metARows = matA.GetLength(0);
            for (int i = 0; i < metARows; i++)
            {
                for (int j = 0; j < metBCols; j++)
                {
                    for (int g = 0; g < metACols; g++)
                    {
                        result[i, j] = matA[i, g] * matB[g, j];
                    }
                }
            }
        }
        static void MultipleMatricParaller(double[,] matA, double[,] matB, double[,] result)
        {
            int metACols = matA.GetLength(1);
            int metBCols = matB.GetLength(1);
            int metARows = matA.GetLength(0);
            Parallel.For(0, metARows, i =>
            {
                for (int j = 0; j < metBCols; j++)
                {
                    for (int g = 0; g < metACols; g++)
                    {
                        result[i, j] = matA[i, g] * matB[g, j];
                    }
                }
            });
        }

        static void Main(string[] args)
        {
            int colCount = 1800;
            int rowCount = 20000;
            int colCount2 = 2700;

            double[,] m1 = InitializeMatrix(rowCount, colCount);
            double[,] m2 = InitializeMatrix(colCount, colCount2);
            double[,] result = new double[rowCount, colCount2];

            Console.WriteLine("Executing sequential loop...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MultipleMatrixSequential(m1, m2, result);
            stopwatch.Stop();
            Console.WriteLine("Sequential loop time in milliseconds " + stopwatch.ElapsedMilliseconds);
            OfferToPrint(rowCount, colCount2, result);
            stopwatch.Reset();

            result = new double[rowCount, colCount2];

            Console.WriteLine("Executing parallel loop...");
            stopwatch.Start();
            MultipleMatricParaller(m1, m2, result);
            stopwatch.Stop();
            Console.WriteLine("Parallel loop time in milliseconds " + stopwatch.ElapsedMilliseconds);
            OfferToPrint(rowCount, colCount2, result);


        }
        static double[,] InitializeMatrix(int rows, int cols)
        {
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = new Random().Next(100);
                }
            }
            return matrix;
        }
        static void OfferToPrint(int rowCount, int colCount, double[,] matrix)
        {
            Console.WriteLine("Computation compeleted; Press y/n :");
            char c = Console.ReadKey().KeyChar;
            if (c == 'y' || c == 'Y')
            {
                Console.WindowWidth = 180;
                Console.WriteLine();
                for (int i = 0; i < rowCount; i++)
                {
                    Console.WriteLine("Row {0}: ", i);
                    for (int j = 0; j < colCount; j++)
                    {
                        Console.Write("{0:#:##}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
