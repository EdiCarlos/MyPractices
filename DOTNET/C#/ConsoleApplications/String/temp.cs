using System;
using System.IO;
using System.Threading;

class filepath
{
public static string file = @"d:\temp\myfile.txt";
}
class writetofile
{
public static void writefile()
{
FileStream fs = new FileStream(filepath.file, FileMode.OpenOrCreate, FileAccess.Write);
StreamWriter sw = new StreamWriter(fs);
Console.WriteLine("Enter something in file");
string str = Console.ReadLine();
sw.WriteLine(str);
//sw.Close();
//fs.Flush();
//fs.Close();
}
}
class readfrom
{

}
class exe
{
public static void Main()
{
writetofile.writefile();
}
}