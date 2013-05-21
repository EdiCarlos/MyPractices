using System;
using System.IO;

class ReadWriteFile
{
public static void Main(string [] args)
{
FileStream fs = new FileStream(@"D:\TEMP\mytext1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
StreamWriter sw = new StreamWriter(fs);
StreamReader sr = new StreamReader(fs);
Console.WriteLine("Press stop to escape");
string str = Console.ReadLine();
while(str != null)
{

if(str.Equals("stop"))
{
break;
}
sw.WriteLine(str);

str = Console.ReadLine();
}

sr.BaseStream.Seek(0, SeekOrigin.Begin);
while(!sr.EndOfStream)
{
Console.WriteLine(sr.ReadLine());
}

sw.Close();
sr.Close();
}
}