using System;

class Read
{
	public int x;
	public readonly int y = 25;
	public readonly int z;
	public Read()
	{
		z = 25;
	} 
	public Read(int a, int b, int c)
	{
		x = a;
		y = b;
		z = c;
	}
	public static void Main()
	{
	  Read r = new Read(1 , 2, 3);
	  Console.WriteLine("Value of x {0}", r.x);
	  Console.WriteLine("Value of y {0}", r.y);
	  Console.WriteLine("Value of z {0}", r.z);
	}
}
