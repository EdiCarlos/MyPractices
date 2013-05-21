using System;
using System.IO;

class myclass
{
public static void Main()
{
FileStream fs = new FileStream(@"d:\temp\mytext", FileMode.OpenOrCreate, FileAccess.ReadWrite);
StreamWriter sw = new StreamWriter(fs);
Console.WriteLine("Write some thing to file");

sw.WriteLine(Console.ReadLine());

sw.Close();
fs.Close();
}
}