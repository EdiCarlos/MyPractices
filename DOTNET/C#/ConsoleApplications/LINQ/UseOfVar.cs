using System;
using System.Collections.Generic;
using System.Diagnostics;

class MyPc
{
public Int32 Id {get; set;}
public Int64 Memory {get; set;}
public string Name {get; set;}
}

class LanguageFeatures
{
public static void Main()
{
var processes = new List<MyPc>();
foreach(var process in Process.GetProcesses())
{
var data = new MyPc();
data.Id = process.Id;
data.Name = process.ProcessName;
data.Memory = process.WorkingSet64;
processes.Add(data);
}
Console.WriteLine(processes);
}
}