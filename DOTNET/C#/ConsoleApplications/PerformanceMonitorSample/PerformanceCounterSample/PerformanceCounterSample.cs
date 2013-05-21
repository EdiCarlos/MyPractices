using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PerformanceCounterSample
{
	/// <summary>
	/// Entry class for the sample
	/// </summary>
	class PerformanceCounterSampleStarter
	{
		/// <summary>
		/// Imports the <code>QueryPerformanceFrequency</code> method into the class. The method is used to measure the current
		/// tickcount of the system.
		/// </summary>
		/// <param name="ticks">current tick count</param>
		[DllImport("Kernel32.dll")]
		public static extern void QueryPerformanceCounter(ref long ticks);

		/// <summary>
		/// Main thread
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			PerformanceCounterSample test = new PerformanceCounterSample();
			Random rand = new Random();
			long startTime = 0;
			long endTime = 0;
			
			for (int i=0; i<1000; i++)
			{
				// measure starting time
				QueryPerformanceCounter(ref startTime);

				System.Threading.Thread.Sleep(rand.Next(500));

				// measure ending time
				QueryPerformanceCounter(ref endTime);

				// do some processing
				test.DoSomeProcessing(endTime - startTime);
			}
		}


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
}
