using System;
using System.Text;
using System.Runtime.InteropServices;

class UsbReadData
{
[DllImport("quickusb.dll", CharSet=CharSet.Ansi)]
static extern int QuickUsbReadData(IntPtr handle, byte[] outData, out int length);

public static void Main(string [] args)
{
byte [] data;
int length = 0;
bool chk = Read(out data, length);
string str = Encoding.ASCII.GetString(data);
Console.WriteLine(str);
}
    public static  bool Read(out byte[] data, int length)
    {
        try
        {
        if (IsOpen)
        {

            byte[] readData = new byte[length];



            int len = readData.Length;

            int result = QuickUsbReadData(handle, readData, out len);
            if (result == 0)
            {
            LastError = "USB Connection is not open";
            //IsOpen = false;
            Close();
            data = readData;
            return false;
            }

            data = readData;
            return true;
        }
        else {
            LastError = "Device not open";
            data = new byte[length];
            return false;
        }
        }
        catch (DllNotFoundException)
        {
        LastError = "Cannot find the QuickUSB dll library. Please install QuickUsb Drivers.";
        data = new byte[length];
        return false;
        }

    }
}