using System;
using System.IO;
using System.Xml;

class MainClass
{    
  static void Main(string[] args)
  {
    string localURL = @"http://ip-address.domaintools.com/myip.xml";
    XmlTextReader xmlreader = null;
    xmlreader = new XmlTextReader (localURL);

    while (xmlreader.Read())
    {
    
    	if(xmlreader.NodeType == XmlNodeType.Element)
    	{
    	
    			Console.WriteLine("Element : " + xmlreader.Name);
    
    	} 

    	if(xmlreader.NodeType == XmlNodeType.Text)
    	{
    		Console.WriteLine("Value : " +xmlreader.Value);
    	}
    }
    if (xmlreader != null)
      xmlreader.Close();

  }
}