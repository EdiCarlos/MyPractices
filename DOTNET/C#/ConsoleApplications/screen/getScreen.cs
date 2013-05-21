using System;	
using System.Drawing;
using System.Windows.Forms;
class exe
{
public static int width, height;

public static void Main()
{
Screen [] scr = Screen.AllScreens;
width = scr[0].Bounds.Width;
height = scr[0].Bounds.Height;
Console.WriteLine("Device Name " + scr[0].DeviceName);
Console.WriteLine("bounds " + scr[0].Bounds.ToString());
Console.WriteLine("Get type " + scr[0].GetType().ToString());
Console.WriteLine("Working Area " + scr[0].WorkingArea.ToString());
Console.WriteLine("Primary Screen  " + scr[0].Primary.ToString());

}
}


