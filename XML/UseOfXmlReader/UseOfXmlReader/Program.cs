using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace UseOfXmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\Development\Honeywell Match File\1100BRD-20100709031955.xml");



            foreach(XmlNode node in doc.DocumentElement.SelectNodes("Record"))
            {
            
            
            }
            //doc.LoadXml(doc.DocumentElement.InnerXml);
            //XmlNamespaceManager namespacemanager = new XmlNamespaceManager(doc.NameTable);
            //namespacemanager.AddNamespace("ns0", "ns0:MT_BOL_Extract");
            //XmlReader read = XmlReader.Create(@"D:\Development\Honeywell Match File\1100BRD-20100709031955.xml");
            //BeginReading(read);
        }

        //private static void BeginReading(XmlReader read)
        //{
        //    int count = 0;
        //    do
        //    {
        //        switch (read.NodeType)
        //        {
        //            case XmlNodeType.Element:
        //                Reread[count + 1].ToString();
        //                break;
        //            case XmlNodeType.Text:
        //                break;
                     
        //        }
        //        count++;
        //    } while (read.Read());
        //}
    }
}
