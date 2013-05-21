using System;

namespace HelloWorldRemote
{
public class RemoteObject : System.MarshalByRefObject
{
public RemoteObject()
{
Console.WriteLine("Hello, World! (RemoteObject constructor) ");
}
}
public class MyRemoteObject : System.MarshalByRefObject
{
public MyRemoteObject()
{
Console.WriteLine("MyRemoteObject constructor called");
}
public void ShowName()
{
Console.WriteLine("arif khan hasan");
}
}
class Program
{
static void Main()
{
Console.WriteLine("Hello world  (Main Method)");
}
}
}