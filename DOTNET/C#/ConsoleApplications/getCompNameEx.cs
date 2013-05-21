using System;
using System.Text;
using System.Runtime.InteropServices;

class getCompNameEx
{
enum COMPUTER_NAME_FORMAT
{
 ComputerNameNetBIOS,
ComputerNameDnsHostName,
ComputerNameDnsDomain,
ComputerNameDnsFullQualified,
ComputerNamePhysicalNetBIOS,	
ComputerNamePhysicalDnsHostName,
ComputerNamePhysicalDnsDomain,
ComputerNamePhysicalDnsFullyQualified

}

[DllImport("kernel32.dll")]
static extern bool GetComputerNameEx(COMPUTER_NAME_FORMAT name, [Out] StringBuilder lbuffer, ref uint size);

[STAThread]
public static void Main(string [] args)
{
StringBuilder name = new StringBuilder(250);
uint size = 250;
GetComputerNameEx(COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsHostName, name, ref size);
Console.WriteLine(name.ToString());

}
}