using System;

class col
{
int [] arr = new int[20];

int count = 0;
public int this[int i]
{
get
{
if(i >= 0 && i < 20)
{
return this[i];
}
else
{
throw new Exception("Index not found Exception");
}
}
set
{
if(i >= 0 && i < 20)
{
this[i] = value;
count++;
}
else
{
throw  new Exception("Index not found Exception");
}
}
}
public int getCount
{
get{return this.count;}
} 
}
class exe
{
public static void Main()
{
try
{
col cl = new col();
cl[0] = 10;
cl[1] = 12;
cl[2] = 20;
for(int i = 0; i < cl.getCount; i++)
{
Console.WriteLine(cl[i]);
}
}
catch(Exception e)
{
Console.WriteLine(e.Message);
}
}
}
