using System;
using System.Text;
using System.Runtime.InteropServices;

class getCompName
{
[DllImport("kernel32.dll")]
static extern bool GetComputerName(StringBuilder buffer, ref uint size);
[DllImport("kernel32.dll")]
static extern unsafe bool GetComputerName(byte* lpbuffer, long* nsize);
public static void Main()
{
getUnSafeName();
}
public static void getUnSafeName()
{
byte[] buffor = new byte[512];
long size = buffor.Length;
unsafe
{
long* psize = &size;
fixed(byte* pbuffor = buffor)
{
GetComputerName(pbuffor, psize);
}
}
string compname = Encoding.ASCII.GetString(buffor);
Console.WriteLine(compname); 
}
public static void getSafeName()
{
StringBuilder str = new StringBuilder(512);
uint size = 512;
bool check= GetComputerName(str, ref size);
Console.WriteLine(check);
Console.WriteLine(size);
Console.WriteLine(str.ToString());

}
}