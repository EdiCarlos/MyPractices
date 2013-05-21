using System;

struct Digit
{
	byte value;
	public Digit(byte value)
	{
		if(value > 9)
		{
			throw new ArgumentException("Value cannot be more than 9");
		}
		this.value = value;
	}
	public static explicit operator Digit(byte b)
	{
		Digit d = new Digit(b);
		Console.WriteLine("Conversion Occured");
		return d;
	}
	public override string ToString()
	{
		return value.ToString();
	}
}

class exe
{
	public static void Main()
	{
		try
		{
			byte b = 10;
			Digit d = (Digit)b;
			Console.WriteLine(d);
		}
		catch(Exception ex)
		{
			Console.WriteLine("Excpetion occurred {0}", ex);
		}
	}
}