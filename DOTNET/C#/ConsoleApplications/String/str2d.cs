using System;
using System.Text;

class exe
{
public static void Main()
{
System.String [,,] str = new System.String[2,2,2];
str[0,0,0] = "arif";
str[0,0,1] = "khan";
str[0,1,0] = "tarik";
str[0,1,1] = "khan";
str[1,0,0] = "afreen";
str[1,0,1] = "khan";
str[1,1,0] = "saima";
str[1,1,1] = "khan";
for(int f = 0; f < 2; f++)
{
for(int j = 0; j < 2; j++)
{
for(int i = 0; i < 2; i++)
{
Console.WriteLine("["+f+","+j+","+i+"] =" + str[f,j,i]);
}
}
}
}
}