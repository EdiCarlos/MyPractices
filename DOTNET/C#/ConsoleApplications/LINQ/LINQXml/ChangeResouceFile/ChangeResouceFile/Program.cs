using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;

namespace ChangeResouceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"D:\MyPractices\DOTNET\C#\ConsoleApplications\LINQ\LINQXml\ChangeResouceFile\ChangeResouceFile\Resource.resx";

            var result1 = (from xd in xdoc.Descendants("root").Descendants("data") where xd.Attribute("name").Value == "cognos10url" select xd).Descendants("value").First();
        }
    }
}
