using System;
using System.IO;
using System.Net;
using System.Text;

namespace Exampel.System.Net
{
public class exe
{
public static void Main()
{
WebRequest request = WebRequest.Create("http://www.google.com");
request.Method = "POST";
string sendtoserv = "this is the string that will be send to web server";
byte[] byteArray = Encoding.UTF8.GetBytes(sendtoserv);
request.ContentType = "application/x-www-form-urlencoded";
request.ContentLength = byteArray.Length;
Stream dataStream = request.GetRequestStream();
dataStream.Write(byteArray, 0, byteArray.Length);
dataStream.Close();
WebResponse response = request.GetResponse();
Console.WriteLine(((HttpWebResponse)response).StatusDescription);
dataStream = response.GetResponseStream();
StreamReader reader = new StreamReader(dataStream);
Console.WriteLine(reader.ReadToEnd());
reader.Close();
dataStream.Close();
response.Close();
}
}
}