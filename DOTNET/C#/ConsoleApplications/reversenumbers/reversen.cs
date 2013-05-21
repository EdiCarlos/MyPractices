using System;

class ReverseNumber
{
	public static void Main()
	{
		int i = 123456789;
		string str = i.ToString();
	  string newstr = string.Empty;
      for (int j = str.Length - 1; j > -1; j--)
      {
          newstr += str[j];
          Console.WriteLine(str[j]);
      }
	  Console.WriteLine(newstr);
      i = Convert.ToInt32(newstr);

	}
}