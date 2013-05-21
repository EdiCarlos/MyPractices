using System;
using System.Runtime.InteropServices;

public delegate bool CallBack(int hwnd, int param);

class myclass
{
[DllImport("user32", SetLastError=true)]
static extern bool EnumWindows(int x, int y);

public static void Main()
{
CallBack cal = new CallBack(myclass.register);

EnumWindows(0, 0);
//Console.WriteLine(myclass.register(0,0));
bool f = Marshal.GetLastWin32Error() == 0 ? false : true 	;
if(!f)
{
Console.WriteLine("Error : {0}", Marshal.GetLastWin32Error());
}

}
public static bool register(int hwnd, int param)
{
Console.WriteLine("window handle is " + hwnd);
return true;
}
}