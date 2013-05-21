using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

class pingClass
{
public static void Main(string [] args)
{
int pingsc = 0, pingf = 0;
int numb = Convert.ToInt32(args[1]);

Ping ping = new Ping();
PingOptions option = new PingOptions();
option.DontFragment = true;

string message = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfasdfasdfasfasdfasdfasdfasdfasdfas";
byte [] val = Encoding.ASCII.GetBytes(message);
int timeout = 120;
for(int i = 0; i < numb; i++)
{
PingReply reply = ping.Send(args[0], timeout, val, option);
if(reply.Status == IPStatus.Success)
{
Console.WriteLine("Address {0} " , reply.Address.ToString());
Console.WriteLine("RoundTrip time {0} " ,reply.RoundtripTime);
Console.WriteLine("Time to live {0}", reply.Options.Ttl);
Console.WriteLine("Buffer size {0}", reply.Buffer.Length); 
pingsc++;
}
else
{
Console.WriteLine("Ping failed");
pingf++;
}
}
Console.WriteLine("number of Success pings {0}", pingsc);
Console.WriteLine("Number of failed pings {0}", pingf);
}

}