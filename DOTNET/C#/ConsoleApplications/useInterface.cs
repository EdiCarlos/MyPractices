using System;

interface ICalculator
{
void Add(int num1, int num2);
void Multiple(int num1, int num2);
void Subtract(int num1, int num2);
void Division(int num1, int num2);
}
class Program : ICalculator
{
public void Add(int num1, int num2)
{
Console.WriteLine(num1 + num2);
}
public void Multiple(int num1, int num2)
{
Console.WriteLine(num1 * num2);

}
public void Subtract(int num1,int num2)
{
Console.WriteLine(num1 - num2);

}
public void Division(int num1, int num2)
{
Console.WriteLine(num1 / num2);

}
public static void Main(String [] args)
{
Console.WriteLine("Enter First Number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Main");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Division");
Console.WriteLine("4. Multiplication");
int choice = Convert.ToInt32(Console.ReadLine());
switch(choice)
{
case 1:
  new Program().Add(number1, number2);
break;
case 2:
new Program().Subtract(number1, number2);
break;
case 3:
new Program().Division(number1, number2);
break;
case 4:
new Program().Multiple(number1, number2);
break;
default:
Console.WriteLine("Unknown Option");
break;
}
} 
}