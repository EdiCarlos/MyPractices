using System;

class infinite
{
 int j = 0;
public static void Main()
{
new infinite().rec();
}

public void rec()
{

if(j <= 10)
{
Console.WriteLine(j);
++j;
rec();
}
else
{
Console.WriteLine("function is returing back");
}
}

}