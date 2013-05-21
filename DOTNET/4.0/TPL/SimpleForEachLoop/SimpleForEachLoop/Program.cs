using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Diagnostics;

namespace SimpleForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"D:\Pics", "*.jpg");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            UseOfSimpleForEachLoop(files);
            stopwatch.Stop();
            Console.WriteLine("Processing time in seconds" + (stopwatch.ElapsedMilliseconds / 1000) % 60);
            stopwatch.Reset();
            Console.WriteLine("Starting for each loop");
            stopwatch.Start();
            UseOfForEachLoop(files);
            stopwatch.Stop();
            Console.WriteLine("Processing time in seconds" + (stopwatch.ElapsedMilliseconds / 1000) % 60);
            
            Console.WriteLine("processing complete press any key to exit");
            Console.ReadKey();
        }

        private static void UseOfSimpleForEachLoop(string [] files)
        {
            string newDir = @"D:\Pics\ParallelForEach";
            Directory.CreateDirectory(newDir);
            
            Parallel.ForEach(files, currentFileName =>
            {
                string fName = Path.GetFileName(currentFileName);
                using (Bitmap bitMap = new Bitmap(currentFileName))
                {
                    bitMap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitMap.Save(newDir + "\\" + fName);
                }
                Console.WriteLine("Processing {0} Thread {1} ", fName, Thread.CurrentThread.ManagedThreadId);
            });
        }
        private static void UseOfForEachLoop(string[] files)
        {
            string newDir = @"D:\Pics\ForEach";
            Directory.CreateDirectory(newDir);
            
            foreach (string currentFileName in files)
            {
                string fName = Path.GetFileName(currentFileName);
                using (Bitmap bitMap = new Bitmap(currentFileName))
                {
                    bitMap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitMap.Save(newDir + "\\" + fName);
                }
                Console.WriteLine("Processing {0} Thread {1} ", fName, Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
