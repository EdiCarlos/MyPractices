using System;

class exe
{
public delegate void AddDelegate(int val, ref int refc);

static void Main()
{
AddDelegate del = (AddDelegate)AddOne + (AddDelegate)AddTwo + (AddDelegate)AddOne;
int valcount  = 0; 
int refcount = 0;
del(valcount, ref refcount);
Console.WriteLine("Value of value count " + valcount);
Console.WriteLine("Value of reference count" + refcount);
}
public static void AddOne(int valcount, ref int refcount)
{
++refcount;
++valcount;
}
public static void AddTwo(int valcount, ref int refcount)
{
valcount += 2;
refcount +=  2;
}
}