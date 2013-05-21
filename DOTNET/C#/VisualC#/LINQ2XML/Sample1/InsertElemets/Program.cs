using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace InsertElemets
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement element = new XElement("Root",
                new XElement("User",
                new XElement("UserName", "axkhan2"),
                new XElement("SessionToken", "Token"),
                new XElement("CustomParameter",
                    new XElement("Param",
                        new XElement("Name", "SponsorID"),
                        new XElement("Value", "SP")
                        )
                        )
                        )
                        );
            element.Descendants("CustomParameter").First<XElement>().Add(new XElement("Param",
                new XElement("Name", "CustomerID"),
                new XElement("Value", "cust")
                ));
 
            Console.WriteLine(element.ToString());

        }
    }
}
