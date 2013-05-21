using System;

class hanoi
{
static void Main()
{
dotower(3, 'a', 'b', 'c');
}
public static void dotower(int numberof, char from, char inter, char to)
{
if(numberof == 1)
{
Console.WriteLine("Disk 1 from " + from + " to " + to);
}
else
{
dotower(numberof - 1, from, to, inter);
Console.WriteLine("Disk " + numberof + " from " + from + " to " + to);
dotower(numberof - 1, inter, from, to );

}
}
}