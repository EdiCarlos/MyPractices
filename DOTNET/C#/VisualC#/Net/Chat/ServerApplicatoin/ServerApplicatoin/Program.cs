using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Timers;

namespace ServerApplicatoin
{
    class Program
    {
           static TcpListener listen;// = new TcpListener(8080);
            static Socket sock;
            //Socket sock = listen.AcceptSocket();       
        static void Main(string[] args)
        {
            IPAddress ipaddress = IPAddress.Parse("59.144.123.113");
            //ipaddress.AddressFamily = AddressFamily.VoiceView;
            listen = new TcpListener(ipaddress, 8080);
            listen.Start();
            sock = listen.AcceptSocket();
            if (sock.Connected)
            {
                Timer time = new Timer();
                time.Elapsed += new ElapsedEventHandler(time_Elapsed);
                time.Enabled = true;
                time.Interval = 200;
                time.Start();
                Console.WriteLine("Client Connected");
                NetworkStream networkStream = new NetworkStream(sock);
                StreamWriter streamWriter = new StreamWriter(networkStream);
                Console.WriteLine("Enter message for client ");
                streamWriter.WriteLine(Console.ReadLine());
                streamWriter.Flush();
              
                Console.WriteLine("Enter message ");
                string message = Console.ReadLine();

                while (!message.Equals("Quit"))
                {
                    streamWriter.Flush();

                    Console.WriteLine("Enter message ");
                    message = Console.ReadLine();
                    networkStream = new NetworkStream(sock);
                    streamWriter.WriteLine(message);
                    streamWriter.Flush();

                }
                networkStream.Close();

            }

            Console.ReadLine();
        }

        static void time_Elapsed(object sender, ElapsedEventArgs e)
        {
            NetworkStream networkStream = new NetworkStream(sock);
            
            if (networkStream.DataAvailable)
            {
                StreamReader reader = new StreamReader(networkStream);
                Console.WriteLine("client : " + reader.ReadLine());
                reader.Close();
            }
        }
       
    }
}
