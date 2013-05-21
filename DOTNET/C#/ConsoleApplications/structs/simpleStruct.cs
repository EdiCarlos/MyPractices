using System;

struct Fraction
{
private int nominator;
private int denominator;
public int Nominator
{
get { return nominator;}
set{nominator = value;}
}

public int Denominator
{
get{return denominator;}
set{denominator = value;}
} 
}

class exe
{
public static void Main()
{
Fraction f = new Fraction();
f.Nominator = 10;
f.Denominator = 20;
Console.WriteLine(f.Nominator);
Console.WriteLine(f.Denominator);
}
}