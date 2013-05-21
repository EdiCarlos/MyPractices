using System;
using System.Runtime.InteropServices;

class shutclass
{
[DllImport("advapi32.dll")]
static extern bool InitiateSystemShutdown(string machinename, string message, uint timeout, bool appclosed, bool restart);
[DllImport("kernel32.dll")]
static extern uint GetLastError();
static void Main()
{
Console.WriteLine(InitiateSystemShutdown(Environment.MachineName, "shuting down", 60 * 1000, false, true) );
}
}
