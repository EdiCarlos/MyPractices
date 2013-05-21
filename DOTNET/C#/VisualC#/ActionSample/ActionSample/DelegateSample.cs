using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionSample
{
    public interface Command
    {
        void Execute(string message);
    }
    delegate void DisplayMessage(string message);
    public class DelegateSample : Command
    {
        void Command.Execute(string message)
        {
            DisplayMessage messagetarget;
            if (!string.IsNullOrEmpty(message))
            {
                messagetarget = Message.ShowWindowMessage;
                messagetarget(message);
            }
            else
            {
                Console.WriteLine("Enter message");
                messagetarget = Console.WriteLine;
                messagetarget("Hello world");
            }
        }
    }
    public static class Message
    {
        public static void ShowWindowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
