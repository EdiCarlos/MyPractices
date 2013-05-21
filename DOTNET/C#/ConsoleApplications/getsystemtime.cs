using System;
using System.Text;
using System.Runtime.InteropServices;

public struct Time
{
public short year;
public short month;
public short dayofweek;
public short day;
public short hour;
public short minutes;
public short secons;
public short milli;
}
class exe
{
[DllImport("kernel32.dll")]
public static extern bool GetSystemTime(ref Time time);
[DllImport("kernel32.dll")]
public static extern bool GetComputerName(StringBuilder build,ref  byte b); 
public static void Main()
{

}
}