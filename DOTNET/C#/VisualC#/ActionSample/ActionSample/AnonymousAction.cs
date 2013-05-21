using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionSample
{
    public class AnonymousAction : Command
    {
        public void Execute(string message)
        {
            Action<string> messagetarget;
            if (!BL.CheckStringIsEmpty(message))
            {
                BL.RunAction(delegate(string msg1) { Message.ShowWindowMessage(msg1); }, message);
            }
            else
            {
                messagetarget = Console.WriteLine;
                BL.RunEmptyAction(messagetarget);
            }
        }
    }
}
