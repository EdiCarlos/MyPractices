using System;
using System.Text;
using System.Runtime.InteropServices;

namespace alert
{
public struct AlertRequest
{
public String name;
public int count;
}
class AlertClass
{
[DllImport("alert.dll", EntryPoint="DoAlertRequestThunk")]
static extern int DoRequestThunk(string requestname, int count);
public static int DoRequest(ref AlertRequest req)
{
return DoRequestThunk(req.name, req.count);
}
}
class exe
{
public static void Main(string [] args)
{
AlertRequest req = new AlertRequest();
req.name = "beep";
req.count = 10;
AlertClass.DoRequest(ref req);
}
}
}