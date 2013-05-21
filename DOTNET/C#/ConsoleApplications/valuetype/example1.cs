using System;

struct mystruct
{
	public int age;
	public string name;
	public string Name
	{
		get{return name;}
		set{name = value;}
	}
	public int Age
	{
		get{return age;}
		set{age = value;}
	}
}
class exe
{
	public static void Main()
	{
		mystruct my = new mystruct();
		my.name = "arif";
		my.age = 22;
		Console.WriteLine(my.Name + " " + my.Age);
		//Console.WriteLine(m.Name + " " + m.Age);
	
	}
}