using System;
using System.Collections.Generic;
using System.Collections;

class Example
{
	public static void OpTest<T>(T s, T t) where T : class
	{
		Console.WriteLine(s == t);
	}
	static private void Main()
	{
		string str1 = "arif";
		System.Text.StringBuilder build = new System.Text.StringBuilder("arif");
		string str2 = build.ToString();
		Console.WriteLine(str1 == str2);
		Console.WriteLine(str2 + " " + str1);
		OpTest<string>(str1, str2);
	}
}