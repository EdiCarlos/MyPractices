using System;

class MyClass : IDisposable
{
	public void Foo()
	{
		Console.WriteLine("use of Foo");
	}
	public void Dispose()
	{
		Console.WriteLine("Disposing Limited resources");
	}
}

class exe
{
	static void Main()
	{
		using(MyClass cl = new MyClass())
		{
			cl.Foo();
		}
		Console.WriteLine("Now outside using statement");
		
		MyClass c = new MyClass();
		using(c){
			c.Foo();
		}
	}
}