using System;
using System.Net;
using System.Text;

namespace IncrementIpAddress
{
class IncIpAddress
{
pirvate string ip1, ip2; 
public IncIpAddress()
{
}

public IncIpAddress(string ip1, string ip2)
{
this.ip1 = ip1;
this.ip2 = ip2;
}

public static void Main()
{
}

public bool IsFristIpGreater(string FirstIp, string SecondIp)
{

try
{
IPAddress add1 = IPAddress.Parse(FirstIp);
IPAddress add2 = IPAddress.Parse(SecondIp);

}
catch(FormatException fe)
{
Console.WriteLine("IpAddress Format is Incorrect Please Correct check the format" + fe.Message);
}

}

}
}