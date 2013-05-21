using System;

namespace myname
{
class myclass
{
public string fname, lname;
public myclass(string fname, string lname)
{
this.fname = fname;
this.lname = lname;
}
public void showName()
{
Console.WriteLine(fname + " " + lname);
}
}
}