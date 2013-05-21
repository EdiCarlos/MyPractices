using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionSample
{
    public class SimpleAction : Command
    {
        public void Execute(string message)
        {
            Action<string> messagetarget;
            if (!String.IsNullOrEmpty(message))
            {
                messagetarget = Message.ShowWindowMessage;
                messagetarget(message);
            }
            else
            {
                messagetarget = Console.WriteLine;
                messagetarget("Hello world");
            }
        }
    }
}
