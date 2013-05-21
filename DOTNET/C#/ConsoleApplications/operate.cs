using System;
class FirstClass
{
int number1, number2;
public FirstClass()
{
}
public FirstClass(int num1, int num2)
{
this.number1 = num1;
this.number2 = num2;
}
public FirstClass(int num1)
{
this.number1 = num1;
}
public static bool operator >=(FirstClass c1, FirstClass c2)
{
return c1.number1 >= c2.number1;
}
public static bool operator <=(FirstClass c1, FirstClass c2)
{
return c1.number1 <= c2.number1;
}
}
class exe
{
public static void Main(String [] args)
{
FirstClass f = new FirstClass(20);
FirstClass f2 = new FirstClass(10);
Console.WriteLine(f <= f2);
}
}