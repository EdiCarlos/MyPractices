using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

class exe
{
	public static void Main()
	{
		ServiceController [] control = ServiceController.GetServices();
		foreach(ServiceController con in control)
		{
		
			if(con.Status.ToString().Equals("Running"))
			{
					Console.WriteLine("============================");
			Console.WriteLine(con.ServiceName);
			Console.WriteLine(con.Status);
			Console.WriteLine("Can Pause and Continue " + con.CanPauseAndContinue);
			Console.WriteLine("Can Shutdown " + con.CanShutdown);
				Console.WriteLine("Can Stop " + con.CanStop);
		  }
		  if(con.ServiceName == "Marimba")
		  {
		  	if(con.Status == ServiceControllerStatus.Running)
		  	{
		  	con.Stop();
		  	}
		  	else
		  	{
		  		con.Start();
		  	}
		  	Thread.Sleep(1000);
		  	con.Refresh();
		  }
		}
	}
}