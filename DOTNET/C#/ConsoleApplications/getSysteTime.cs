using System;
using System.Text;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Sequential)]
public struct SystemTime
{
public short year;
public short month;
public short daysofweek;
public short day;
public short hour;
public short minute;
public short seconds;
public short milliseconds;
}
class getTime
{

[DllImport("kernel32.dll")]
public static extern void GetSystemTime(ref SystemTime time);
[DllImport("kernel32.dll")]
static extern uint SetSystemTime(ref SystemTime time);

public static void Main(string [] args)
{
try
{

SystemTime time = new SystemTime();
GetSystemTime(ref time);
Console.WriteLine("Year : " +time.year);
Console.WriteLine("month : " +time.month);
Console.WriteLine("Days of Week : " +time.daysofweek);
Console.WriteLine("Day : " + time.day);
Console.WriteLine("Hours : " + time.hour);
Console.WriteLine("minutes : " + time.minute);
Console.WriteLine("Seconds : " + time.seconds);
Console.WriteLine("milliseconds : " + time.milliseconds);
time.year += 1;
SetSystemTime(ref  time);

Console.WriteLine("new year " + time.year);
}
catch(Exception e)
{
System.Windows.Forms.MessageBox.Show(e.Message);
}
}
}