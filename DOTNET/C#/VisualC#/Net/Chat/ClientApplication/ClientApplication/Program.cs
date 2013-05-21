using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Timers;

namespace ClientApplication
{
    class Program
    {
        static TcpClient client;
        static NetworkStream networkStream;
        static void Main(string[] args)
        {
            
            client = new TcpClient("59.144.123.113", 8080);
            networkStream = client.GetStream();
            StreamReader streamReader = new StreamReader(networkStream);
            //StreamWriter streamWriter = new StreamWriter(networkStream);
            try
            {
                Timer time = new Timer(500);
                time.Elapsed += new ElapsedEventHandler(time_Elapsed);
                time.Start();
                Console.WriteLine(streamReader.ReadLine());
                while (client.Connected)
                {
                    //networkStream = client.GetStream();
                    //streamReader = new StreamReader(networkStream);
                    //Console.WriteLine("server : " + streamReader.ReadLine());

                    Console.WriteLine("Write to server");
                    StreamWriter write = new StreamWriter(networkStream);
                    write.WriteLine(Console.ReadLine());
                    write.Flush();
                   // System.Threading.Thread.Sleep(100);
                }
                //Console.WriteLine("Enter message to server");
                //streamWriter.WriteLine("Message from client");
                //streamWriter.Flush();
            }
            catch
            {
                Console.WriteLine("Exception reading from server");
            }
            networkStream.Close();
            streamReader.Close();
            Console.ReadLine();
        }

        static void time_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (networkStream != null)
            {
                networkStream.ReadTimeout = 200;
                StreamReader reader = new StreamReader(networkStream);
                if (networkStream.DataAvailable)
                {
                    Console.WriteLine("Server : " + reader.ReadLine());
                }
            }
        }
    }
}
