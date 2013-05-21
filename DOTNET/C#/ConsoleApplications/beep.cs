using System;
using System.Runtime.InteropServices;

class beepClass
{
[DllImport("User32.dll", SetLastError= true)]
public static extern Boolean MessageBeep(UInt32 beep);
[DllImport("advapi32.dll")]
public static extern int GetUserNameA(string str, int size);

public static void Main()
{
string str;
int val = GetUserNameA(str, 25);
Console.WriteLine(str);
}
}