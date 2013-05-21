using System;

class A
{
}
class B
{
}
class exe
{
public static void Main()
{
	A a = new A();
	B b = new B();
	if(a is A)
	{
		Console.WriteLine("a is object of class A");
	}
	else
	{
			Console.WriteLine("a is not an object of class A");
		}
		if(b is B)
		{
		Console.WriteLine("b is object of class B");
				}
				else
				{
						Console.WriteLine("b is not an object of class B");
	
				}
		if(typeof(A) == a.GetType())
		{	Console.WriteLine("a is object of class A");
		}
		else
	{
		Console.WriteLine("a is not an object of class A");
	}
}

}