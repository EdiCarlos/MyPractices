using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionSample
{
    public class ForEachAction : Command
    {

        public void Execute(string message)
        {
            List<string> someStrings = new List<string>();
            someStrings.Add("Arif");
            someStrings.Add("Khan");
            someStrings.Add("Hasan");

            someStrings.ForEach(Message.ShowWindowMessage);

            someStrings.ForEach(delegate(string name) { Console.WriteLine(name); });
            someStrings.ForEach((s) => { Console.WriteLine(s); });
        }
    }
}
