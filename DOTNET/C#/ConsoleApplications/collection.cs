using System;

class Collection
{
public int maxcount = 20;
private int size;
private string [] item;
public Collection()
{
this.item = new string[maxcount];
this.size = 0;
}
public int Count
{
get { return this.size;}
}
public bool Add(string var)
{

if(this.size < 20)
{
this.item[this.size] = var;
this.size++;
return true;
}
return false;
}
public string getItems(int i)
{
if(i >= 0 && i <= this.size)
{
return this.item[i];

}
else
{
throw new Exception("Index not found exception");
}
return this.item[i];
}

//insert values in the array at a specified position

public bool Insert(string var, int pos)
{
if(size < 20 && pos >= 0 && pos <= size)
{
for(int i = size; i >= pos - 1; i--)
{
this[i + 1] = this[i];
}
this[pos] = var;
this.size++;
return true;
}
return false;
}
public string this[int pos]
{
get { return this.item[pos]; }
set { this.item[pos] = value; }
}
}
class Program
{
public static void Main(string [] args)
{
Collection item = new Collection();
item.Add("Arif");
item.Add("khan");
item.Add("hasan");
item.Add("noor");
item.Add("hasan");
item.Add("Mohammed");
try
{
showValue(item);
}
catch(Exception e)
{
Console.WriteLine(e.Message);
}
//Console.WriteLine("Number of values in collection {0} ", item.Count);
Console.WriteLine("Insert new Item");
string name = Console.ReadLine();
Console.WriteLine("Position to insert at");
int pos = Convert.ToInt32(Console.ReadLine());
item.Insert(name, pos);
Console.WriteLine("Arrays values after insertion ");
showValue(item);
}
public static void showValue(Collection item)
{
for(int i = 0; i < item.Count; i++)
{
Console.WriteLine("Item number {0} : {1}", i, item[i]);
}
}
}