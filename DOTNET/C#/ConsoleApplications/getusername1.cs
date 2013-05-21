using System;
using System.Text;
using System.Runtime.InteropServices;

class exe
{
[DllImport("advapi32.dll", SetLastError = true)]
static extern bool GetUserName(StringBuilder build, ref int buff);
static void Main()
{
StringBuilder name = new StringBuilder();
int i =  50;
bool check = GetUserName(name, ref i);
Console.WriteLine(name + " " + check);
}
}