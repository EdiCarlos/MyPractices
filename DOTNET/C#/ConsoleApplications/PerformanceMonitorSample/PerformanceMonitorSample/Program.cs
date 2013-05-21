using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

namespace PerformanceMonitorSample
{
    class Program
    {
        [DllImport("Kernel32.dll")]
        public static extern void QueryPerformanceCounter(ref long ticks);

        static void Main(string[] args)
        {
            //PerformanceCounterCategory.Delete("Tranmanager");
            TempRunProcess();
            //TempRunProcess1();
            //TempRunProcess2();
            //Program prog = new Program();
            //prog.TempRunProcess3();
        }
        public static void TempRunProcess()
        {
            TranPerformanceCounter.Start(new Program().GetType(), MethodBase.GetCurrentMethod().Name);
            TranPerformanceCounter.Start(new Program().GetType(), MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }
            TranPerformanceCounter.Stop();
        }

        //public static void TempRunProcess1()
        //{
        //    TranPerformanceCounter.Start(new Program().GetType(), MethodBase.GetCurrentMethod().Name);
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Thread.Sleep(100);
        //    }
        //    TranPerformanceCounter.Stop();
        //}

        //public static void TempRunProcess2()
        //{
        //    TranPerformanceCounter.Start(new Program().GetType(), MethodBase.GetCurrentMethod().Name);
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Thread.Sleep(100);
        //    }
        //    TranPerformanceCounter.Stop();
        //}

        //public void TempRunProcess3()
        //{
        //    TranPerformanceCounter.Start(new Program().GetType(), MethodBase.GetCurrentMethod().Name);
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Thread.Sleep(100);
        //    }
        //    TranPerformanceCounter.Stop();
        //}
    }

    /// <summary>
    /// The PerformanceCounterSample class sets up a performance counter category called "MyCategory" if it does not already
    /// exists and adds some counters to it. It provides a method to increment these counters.
    /// </summary>
    public class PerformanceCounterSample
    {
        /// <summary>
        /// Counter for counting total number of operations
        /// </summary>
        private PerformanceCounter _TotalOperations;
        /// <summary>
        /// Counter for counting number of operations per second
        /// </summary>
        private PerformanceCounter _OperationsPerSecond;
        /// <summary>
        /// Counter for counting duration averages
        /// </summary>
        private PerformanceCounter _AverageDuration;
        /// <summary>
        /// Counter for counting duration averages base
        /// </summary>
        private PerformanceCounter _AverageDurationBase;

        /// <summary>
        /// Creates a new performance counter category "MyCategory" if it does not already exists and adds some counters to it.
        /// </summary>
        public PerformanceCounterSample()
        {
            if (!PerformanceCounterCategory.Exists("MyCategory"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection();

                // 1. counter for counting totals: PerformanceCounterType.NumberOfItems32
                CounterCreationData totalOps = new CounterCreationData();
                totalOps.CounterName = "# operations executed";
                totalOps.CounterHelp = "Total number of operations executed";
                totalOps.CounterType = PerformanceCounterType.NumberOfItems32;
                counters.Add(totalOps);

                // 2. counter for counting operations per second: PerformanceCounterType.RateOfCountsPerSecond32
                CounterCreationData opsPerSecond = new CounterCreationData();
                opsPerSecond.CounterName = "# operations / sec";
                opsPerSecond.CounterHelp = "Number of operations executed per second";
                opsPerSecond.CounterType = PerformanceCounterType.RateOfCountsPerSecond32;
                counters.Add(opsPerSecond);

                // 3. counter for counting average time per operation: PerformanceCounterType.AverageTimer32
                CounterCreationData avgDuration = new CounterCreationData();
                avgDuration.CounterName = "average time per operation";
                avgDuration.CounterHelp = "Average duration per operation execution";
                avgDuration.CounterType = PerformanceCounterType.AverageTimer32;
                counters.Add(avgDuration);

                // 4. base counter for counting average time per operation: PerformanceCounterType.AverageBase
                CounterCreationData avgDurationBase = new CounterCreationData();
                avgDurationBase.CounterName = "average time per operation base";
                avgDurationBase.CounterHelp = "Average duration per operation execution base";
                avgDurationBase.CounterType = PerformanceCounterType.AverageBase;
                counters.Add(avgDurationBase);


                // create new category with the counters above
                PerformanceCounterCategory.Create("MyCategory", "Sample category for Codeproject", counters);
            }

            // create counters to work with
            _TotalOperations = new PerformanceCounter();
            _TotalOperations.CategoryName = "MyCategory";
            _TotalOperations.CounterName = "# operations executed";
            _TotalOperations.MachineName = ".";
            _TotalOperations.ReadOnly = false;
            _TotalOperations.RawValue = 0;

            _OperationsPerSecond = new PerformanceCounter();
            _OperationsPerSecond.CategoryName = "MyCategory";
            _OperationsPerSecond.CounterName = "# operations / sec";
            _OperationsPerSecond.MachineName = ".";
            _OperationsPerSecond.ReadOnly = false;
            _OperationsPerSecond.RawValue = 0;

            _AverageDuration = new PerformanceCounter();
            _AverageDuration.CategoryName = "MyCategory";
            _AverageDuration.CounterName = "average time per operation";
            _AverageDuration.MachineName = ".";
            _AverageDuration.ReadOnly = false;
            _AverageDuration.RawValue = 0;

            _AverageDurationBase = new PerformanceCounter();
            _AverageDurationBase.CategoryName = "MyCategory";
            _AverageDurationBase.CounterName = "average time per operation base";
            _AverageDurationBase.MachineName = ".";
            _AverageDurationBase.ReadOnly = false;
            _AverageDurationBase.RawValue = 0;
        }

        /// <summary>
        /// Increments counters.
        /// </summary>
        /// <param name="ticks">The number of ticks the AverageTimer32 counter must be incremented by</param>
        public void DoSomeProcessing(long ticks)
        {
            // simply increment the counters
            _TotalOperations.Increment();
            _OperationsPerSecond.Increment();
            _AverageDuration.IncrementBy(ticks); // increment the timer by the time cost of the operation
            _AverageDurationBase.Increment(); // increment base counter only by 1
        }
    }
    public static class TranPerformanceCounter
    {
        public static PerformanceCounter _elapsedTime;
        const string CategoryName = "Tranmanager";
        private static bool started = false;
        private static void CreatePerformanceCounterCategory(Type type)
        {
            CounterCreationDataCollection counterCollection = new CounterCreationDataCollection();
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                CounterCreationData countPerSecond = new CounterCreationData();
                countPerSecond.CounterName = method.Name;
                countPerSecond.CounterHelp = "Execution time taken per second for an operation";
                countPerSecond.CounterType = PerformanceCounterType.ElapsedTime;
                counterCollection.Add(countPerSecond);
            }
            PerformanceCounterCategory.Create(CategoryName, "Record's Tranamanger service's execution time", PerformanceCounterCategoryType.Unknown, counterCollection);
        }
        public static void Start(Type type, string counterName)
        {
            if (started == false)
            {
                started = true;
            }
            else if (started)
            {
                return;
            }
            if (!PerformanceCounterCategory.Exists(CategoryName))
            {
                CreatePerformanceCounterCategory(type);
            }
            else if (!PerformanceCounterCategory.CounterExists(counterName, CategoryName))
            {
                PerformanceCounterCategory.Delete(CategoryName);
                CreatePerformanceCounterCategory(type);
            }

            _elapsedTime = new PerformanceCounter();
            _elapsedTime.CategoryName = CategoryName;
            _elapsedTime.CounterName = counterName;
            _elapsedTime.ReadOnly = false;
            _elapsedTime.RawValue = Stopwatch.GetTimestamp();
        }
        public static void Stop()
        {
            _elapsedTime.NextValue();
            started = false;
        }
    }
}
