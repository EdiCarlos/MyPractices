using System;
using System.Runtime.InteropServices;

class exitWindows
{
[DllImport("user32.dll")]
static extern bool Exit(uint num1, uint num2);
static void Main()
{
//Console.WriteLine(ExitWindows(0, 0));
}
}