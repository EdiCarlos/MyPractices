using System;
using System.Threading;

class MessageBoard
{
private string messages = "no messages";
public void Reader()
{
Console.WriteLine("Entered Reader thread");
try
{
Monitor.Enter(this);
if(messages == "no messages")
{
Console.WriteLine("{0} {1}", Thread.CurrentThread.Name, messages);
Console.WriteLine("{0} waiting", Thread.CurrentThread.Name);
Monitor.Wait(this);
}
else
{
Console.WriteLine("Could enter if statement");
}
Console.WriteLine("{0} {1}", Thread.CurrentThread.Name, messages);
}
finally
{
Monitor.Exit(this);
}
Console.WriteLine("Exiting reader thread");
}
public void Writer()
{
Console.WriteLine("Enter writer Thread");
try
{
//Monitor.Enter(this);
messages = "Greetings";
Console.WriteLine("{0} Done writing " , Thread.CurrentThread.Name);
//Monitor.Pulse(this);
}
finally
{
//Monitor.Exit(this);
}
Console.WriteLine("Exiting Writer thread");
}
}
class exe
{
public static void Main()
{
MessageBoard message = new MessageBoard();
Thread reader = new Thread(new ThreadStart(message.Reader));
reader.Name = "ReaderThread";
Thread writer = new Thread(new ThreadStart(message.Writer));
writer.Name = "Writer thread";
reader.Start();
reader.SetPriority = 
writer.Start();


}
}