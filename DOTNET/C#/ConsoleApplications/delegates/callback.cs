using System;

public delegate void Del(string message);
public delegate int RetVal(int num1 ,int num2);
class myclass
{
	static void Main()
	{
		mycl c = new mycl();
		myclass cl = new myclass();
		c.MyDelEvent += new Del(cl.ShowDel);
		c.RaiseMyDelegateEvent("Hello world");
		}
		public void ShowDel(string message)
		{
			Console.WriteLine(message);
		}
}
class mycl
{
public event Del MyDelEvent;
	
		public void RaiseMyDelegateEvent(string message)
	{
		Console.WriteLine("Raise My Delegate called this raise event");
		  this.MyDelEvent(message);
	
	}
}