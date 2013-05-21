using System;
using System.Diagnostics;

class StartNotepad
{
static void Main()
{
ProcessStartInfo info = new ProcessStartInfo();
info.FileName = "Notepad.exe";
Process newProc = Process.Start(info);
Console.WriteLine("new Process started");
newProc.WaitForExit();
Console.WriteLine("new process stopped");
}
}