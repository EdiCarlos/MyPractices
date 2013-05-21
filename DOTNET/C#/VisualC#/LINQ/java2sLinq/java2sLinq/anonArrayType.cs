using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace java2sLinq
{
    class anonArrayType
    {
        public static void ShowAnontypeArray()
        {
            var family = new[] {new {FName = "Arif", LName = "Khan", MName= "BanneHasan"},
                new {FName = "Noor", LName = "Mohammed", MName= "BanneHasan"},
                new {FName = "Kaneez", LName = "Bano", MName= "BanneHasan"},
        new {FName = "BanneHasan", LName = "Khan", MName= "Zaheer"}};
            var result = (from fm in family where fm.FName.StartsWith("Kan") select fm).First();
            Console.WriteLine("Frist Name " + result.FName + " Last Name " + result.LName + " Middle Name " + result.MName);
            
            //foreach (var var in result)
            //{
            //}
        }
    }
}
