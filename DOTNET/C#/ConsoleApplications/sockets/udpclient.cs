using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class MainClass
{
   public static void Main()
   {
      byte[] data = new byte[1024];
      string input, stringData;
      UdpClient udpClient = new UdpClient("127.0.0.1", 9999);

      IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

      string welcome = "Hello";
      data = Encoding.ASCII.GetBytes(welcome);
      udpClient.Send(data, data.Length);

      data = udpClient.Receive(ref sender);

      Console.WriteLine("Message received from {0}:", sender.ToString());
      stringData = Encoding.ASCII.GetString(data, 0, data.Length);
      Console.WriteLine(stringData);

      while(true)
      {
         input = Console.ReadLine();
         udpClient.Send(Encoding.ASCII.GetBytes(input), input.Length);
         data = udpClient.Receive(ref sender);
         stringData = Encoding.ASCII.GetString(data, 0, data.Length);
         Console.WriteLine(stringData);
      }
      udpClient.Close();
   }
}