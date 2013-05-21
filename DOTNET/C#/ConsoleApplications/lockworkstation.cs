using System;
using System.Runtime.InteropServices;

class lockstation
{
[DllImport("user32.dll")]
static extern void LockWorkStation();
static void Main()
{
LockWorkStation();
}
}