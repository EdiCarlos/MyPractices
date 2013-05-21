using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace java2sLinq
{
    class anonType
    {
        public static void ShowAnonymousTypeExample()
        {
            var name = new { FName = "Arif", LName = "Khan", MName = "BanneHasan" };
            Console.WriteLine(name.FName + " " + name.LName + " " + name.MName);
        }
    }
}
