using System;
using System.Net.Sockets;
using System.Text;

class TcpTimeClients
{
public static void Main()
{
try
{
TcpClient client = new TcpClient("www.yahoo.com", 80);
NetworkStream ns = client.GetStream();
byte[] bytes = new byte[1024];
int bytesRead = ns.Read(bytes, 0, bytes.Length);
Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));
client.Close();
}
catch(Exception e)
{
Console.WriteLine(e.Message);
}
}
}