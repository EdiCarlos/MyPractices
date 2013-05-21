using System;

namespace MyDl
{
public class myclass
{
	
	public myclass()
	{
		Console.WriteLine("constructor of myclass");
	}
	public string AddName(string fname, string lname)
	{
		return fname +" " + lname;
	}
}

}