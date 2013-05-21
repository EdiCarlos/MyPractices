using System;

class invocateclass
{
public delegate int IncrementDelegate(ref int count);
static void Main()
{
IncrementDelegate [] incarr = { Incrementer, Incrementer, Incrementer, Incrementer, Incrementer };
IncrementDelegate del = (IncrementDelegate)IncrementDelegate.Combine(incarr);
int result = 1;
int count = 1;
foreach(IncrementDelegate inc in del.GetInvocationList())
{
result = result * inc(ref count);
}
Console.WriteLine(result);
}
public static int Incrementer(ref int count)
{
return count++;
} 
}