using System;

class exe
{
public static void Main()
{
string str =String.Concat("arif", " ", "khan", " " , "hasan");
Console.WriteLine(str);
string nstr = str.Remove(0, 5);
Console.WriteLine(nstr);
nstr = nstr.Replace("khan", "arif");
Console.WriteLine(nstr);
}
}