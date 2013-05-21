using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class MainClass
{
   public static void Main()
   {
      int receivedDataLength;
      byte[] data = new byte[1024];
      IPEndPoint ip = new IPEndPoint(IPAddress.Any, 9999);

      Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);

      socket.Bind(ip);

      IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
      EndPoint Remote = (EndPoint)(sender);

      while(true)
      {
         data = new byte[1024];
         receivedDataLength = socket.ReceiveFrom(data, ref Remote);
       
         Console.WriteLine(Encoding.ASCII.GetString(data, 0, receivedDataLength));
         socket.SendTo(data, receivedDataLength, SocketFlags.None, Remote);
      }

   }
}