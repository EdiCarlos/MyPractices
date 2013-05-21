using System;
using System.Diagnostics;

class mycmd
{
static void Main()
{
Process proc = new Process();
proc.StartInfo.FileName = "cmd.exe";
proc.StartInfo.Arguments = "/c ping www.google.com";
proc.StartInfo.UseShellExecute = false;
proc.StartInfo.RedirectStandardOutput = true;
proc.Start();
string output = proc.StandardOutput.ReadToEnd();
Console.WriteLine(output);
}
}