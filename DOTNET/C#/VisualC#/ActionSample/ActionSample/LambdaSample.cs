using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionSample
{
    public class LambdaAction : Command
    {
        public void Execute(string message)
        {
            Action<string> messagetarget;
            if (!BL.CheckStringIsEmpty(message))
            {
                BL.RunAction(s => Message.ShowWindowMessage(s), message);
            }
            else
            {
                BL.RunEmptyAction(s => Message.ShowWindowMessage(s));
            }
        }
    }
}
