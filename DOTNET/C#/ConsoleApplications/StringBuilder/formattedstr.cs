using System;
using System.Text;

class exe
{
public static void Main()
{
int count = 0;
StringBuilder build = new StringBuilder();
build.Append("{0} {1}", count++, "this is formatted string");
Console.WriteLine(build);
}
}