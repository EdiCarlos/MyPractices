using System;

interface ICalculator
{
void Add(int num1, int num2);
//void Multiple(int num1, int num2);
//void Subtract(int num1, int num2);
//void Division(int num1, int num2);
}

class Program : ICalculator
{
void ICalculator.Add(int num1, int num2)
{
Console.WriteLine(num1 + num2);
}
public static void Main(String [] args)
{
Program prog = new Program();
((ICalculator)prog).Add(100, 200);
}
}