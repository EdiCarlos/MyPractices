using System;

public delegate void MyDelegate();
class exe
{
public static MyDelegate [] getDelegates()
{
MyDelegate [] del = new MyDelegate[3];
for(int i =0; i < 3; i++)
{
del[i] = delegate{Console.WriteLine("Hi");};
}
return del;
}
public static MyDelegate getDelegate()
{
MyDelegate del = delegate{ Console.WriteLine("This is my delegates");};
return del;
}
static void Main()
{
MyDelegate [] del = getDelegates();
MyDelegate del1 = getDelegate();

for(int i = 0; i < 3; i++)
{
del[i]();
}
del1 += (MyDelegate)Delegate.Combine(del);
del1();
}
}