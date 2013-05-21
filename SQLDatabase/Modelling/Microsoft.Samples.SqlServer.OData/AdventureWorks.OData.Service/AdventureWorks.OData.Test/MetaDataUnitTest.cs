using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Xml;


//Given, When, Then 
namespace AdventureWorks2012_ODataTest
{
    [TestClass]
    public class MetaDataUnitTest
    {
        XNamespace xmlns = "http://schemas.microsoft.com/ado/2008/09/edm";
        string InArgument_Url = "http://localhost:1234/AdventureWorks.svc/$metadata";
   
        [TestMethod]
        public void GetResourceNamesTestMethod()
        {
            //Given: A url to a WCF 5.0 service is given as InArgument_Url
            
            //When: A LINQ to XML query is constructed with an EntitySet element
            IEnumerable<string> resources = from x in XElement.Load(InArgument_Url)
                .Descendants(xmlns.GetName("EntitySet"))
                select x.Attribute("Name").Value;

            //Then: Retrun an IEnumerable list of Entity Data Model resource names
            Assert.IsTrue(resources.Count<string>() > 0);
        }
    }
}
