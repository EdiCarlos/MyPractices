using System;

struct Roman
{
private int val;
public Roman(int val)
{
this.val = val;
}
public static implicit operator Roman(int val)
{
return new Roman(val);
}
public static explicit operator int(Roman val)
{
return val.val;
}
public static explicit operator string(Roman val)
{
return "conversion failed";
}
}
class exe
{
static void Main(string [] args)
{
Roman numeral = 10;
Console.WriteLine((int)numeral);
Console.WriteLine((string)numeral);
Console.WriteLine((Roman)numeral);
}
}