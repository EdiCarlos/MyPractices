using System;
using System.Net;

class AddressSample
{
public static void Main()
{
IPAddress test1 = IPAddress.Any;
IPAddress test2 = IPAddress.Loopback;
Console.WriteLine("broadcast address : {0} " , test2.ToString());
Console.WriteLine("Any IP Address : {0} " , test1.ToString());
}
}