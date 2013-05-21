using System;

class Machine
{
string name;
public Machine(string name)
{
this.name = name;
}
public void Process(string message)
{
Console.WriteLine("{0} : {1}", name, message);
}
}
class exe
{
public delegate void showProcess(string str);
public static void Process(string message)
{
Console.WriteLine("exe.process sends this message " + message);
}
static void Main()
{
Machine computer = new Machine("Intel");
showProcess proc = computer.Process;
proc = (showProcess)Delegate.Combine(proc, new showProcess(Process));
proc("pentium");
}
}