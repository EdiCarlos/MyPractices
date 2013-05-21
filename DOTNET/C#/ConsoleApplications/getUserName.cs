using System;
using System.Runtime.InteropServices;
using System.Text;
class getUserName
{
[DllImport("advapi32.dll", SetLastError=true)]
static extern bool GetUserName(StringBuilder lpBuffer, ref int size);
public static void Main()
{
StringBuilder build = new StringBuilder(64);
int nSize = 64;
GetUserName(build, ref nSize);
Console.WriteLine(build.ToString());
}
}