//Delegate with return value written on 5-feb-2009
using System;

namespace mydelegate
{
public delegate int ReturnValue();
public delegate string AddString(string str, string str1);
class exe
{
static void Main()
{
ReturnValue val = new ReturnValue(GetInteger);
Console.WriteLine(val());
AddString addstr = null;
parDel(addstr, "khan");
Console.WriteLine(parDel(addstr, "Khan"));
}
public static string parDel(AddString dstr, string str)
{
dstr = new AddString(mystringfunction);
return dstr("Arif", str);
}
public static string mystringfunction(string name, string fname)
{
return name + " " + fname;
}
public static int GetInteger()
{
return 100;
}

}
}