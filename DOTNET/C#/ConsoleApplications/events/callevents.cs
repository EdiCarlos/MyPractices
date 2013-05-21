using System;

public delegate void ShowTen();
public delegate int IncrementValue(int i);
public delegate void CountInitialized(int i);
class NegativeException : ApplicationException
{
public NegativeException(string message) : base(message)
{
}
}
class myclass
{
private int count;
public static event IncrementValue ten;
public static event ShowTen twenty;
public static event ShowTen thirty;
public static event CountInitialized countSet;
public myclass()
{
}
public int Count
{
get{return count;}
set{
if(value <= 0)
{
throw new  NegativeException("Value cannot be zero or negative");
}
else
{
count = value;
if(count > 0)
{
countSet(count);
}
}
}
}
public void runloop()
{
for(int i = 0; i < count; i++)
{
Console.WriteLine(i);
if(i == 10)
{
i = ten(i);
}
if(i== 20)
{
twenty();
}
if(i == 30)
{
thirty();
}
}
}

}
class exe
{
static void Main()
{
exe e = new exe();
myclass.ten += new IncrementValue(e.OnTen);
myclass.twenty += new ShowTen(e.OnTwenty);
myclass.thirty += new ShowTen(e.OnThirty);
myclass.countSet += new CountInitialized(e.showCount);
try
{
myclass cl = new myclass();
cl.Count = 40;
cl.runloop();
}
catch(NegativeException ng)
{
Console.WriteLine(ng.Message);
}
}
public void showCount(int j)
{
Console.WriteLine("Value of count initialized to " + j);
}
public void OnThirty()
{
Console.WriteLine("i is equal to 30");
}
public void OnTwenty()
{
Console.WriteLine("i is equals to 20");
}
public int OnTen(int i)
{
Console.WriteLine("i is equals to 10");
return i += 12;
}
}