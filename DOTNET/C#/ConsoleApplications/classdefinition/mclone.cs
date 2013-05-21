using System;

class myValue
{
public int count;

public myValue(int val)
{
this.count = val;
}
}
class myObject
{
public myValue contained;
public myObject(int count)
{
this.contained = new myValue();
}
public myObject Cloned()
{
Console.WriteLine("Clone");
return (myObject) MemeberwiseClone();
}
}
class exe
{
public static void Main(string [] args)
{
myObject my = new myObject(int count);
myObject myobj = my.Cloned();
Console.WriteLine("values: {0} {1} " , my.contained.count, myobj.contained.count);
myObject.contained.count = 1;
Console.WriteLine("values: {0} {1} " , my.contained.count, myobj.contained.count);


}
}