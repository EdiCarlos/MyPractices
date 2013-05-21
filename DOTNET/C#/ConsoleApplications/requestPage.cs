using System;
using System.Net;
using System.IO;

class myclass
{
public static void Main()
{
WebClient cl = new WebClient();
Stream str = cl.OpenRead("http://www.google.com");
StreamReader read = new StreamReader(str);
Console.WriteLine(read.ReadToEnd());
str.Close();

}
}