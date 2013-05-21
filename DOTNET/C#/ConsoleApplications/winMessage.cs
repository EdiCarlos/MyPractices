using System;
using System.Runtime.InteropServices;
namespace message
{
[Flags]
public enum MessageBoxOptions : uint
{
Ok = 0,
OkCancel = 1,
AbortRetryIgnore = 2,
YesNoCancel = 3,
YesNo = 4,
RetryCancel = 5,
CancelTryContinue = 6,

IconHand = 10,
IconQuestion = 20,
IconExclamation  = 30,
IconAsterisk = 40,
UserIcon = 80,

DefButton1 = 0x000000,
DefButton2 = 0x000100,
DefButton3 = 0x000200,
DefButton4 = 0x000300,

ApplicationModal = 0X000000,
SystemModal = 0X001000,
TaskModal = 0X003000,

Help = 0X004000,
NoFocus = 0X008000,

SetForeground  = 0x010000,
DefaultDesktopOnly = 0x020000,
Topmost = 0X040000,
Right = 0x080000,
RTLReading = 0X100000,
}
public enum MessageBoxResult : uint
{
ok = 1,
Cancel,
Abort,
Retry,
Ignore,
Yes,
No,
Close, 
Help,
TryAgain,
Continue,
Timeout = 32000
}
class winMessage
{
[DllImport("user32.dll", CharSet=CharSet.Auto)]
static extern int  MessageBox(IntPtr ptr, string text, string caption, MessageBoxOptions options);
[DllImport("user32.dll", CharSet=CharSet.Auto)]
static extern int MessageBox(IntPtr ptr, string text, string caption, uint var);
[DllImport("user32.dll", CharSet=CharSet.Auto)]
static extern int MessageBox(IntPtr ptr, string text, uint i);

public static void Main()
{
MessageBoxResult result;
result = (MessageBoxResult)MessageBox(IntPtr.Zero, "This is Ok Message Box", 0X080000);

}
}
}