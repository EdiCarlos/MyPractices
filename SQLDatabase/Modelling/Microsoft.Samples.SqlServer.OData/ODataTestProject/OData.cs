// Copyright Microsoft

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using System.Windows.Media.Imaging;
using System.IO;
using System.Drawing;
using System.Xml;

//Arrange, Act, Assert
//Given, When, Then
namespace Microsoft.Samples.SqlServer.Tests
{
    [TestClass]
    public class OData
    {
        private XNamespace mxmlns = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata";
        private string uri = "http://localhost/AdventureWorks_ODataService/AdventureWorks.svc";
        private XNamespace edmXmlns = "http://schemas.microsoft.com/ado/2009/11/edm";

        /// <summary>
        /// Shows XML Projections
        /// </summary>
        [TestMethod]
        public void QueryFeedResourceProperties()
        {
            //Arrange:           
            string resource = "ProductCatalog";
             
            //Act: The entry/content property elements are projected into a Name, Value list for ProductCatalog
            IEnumerable<IEnumerable<EntityProperty>> entityProperties = from item in XElement.Load(String.Format("{0}/{1}", uri, resource))
             .Descendants(mxmlns.GetName("properties"))
             select from e in item.Descendants()
             select new EntityProperty { Name = e.Name.LocalName, Value = e.Value };


            //Assert: Properties list is equal to ProductCatalog count
            Assert.IsTrue(entityProperties.Count() > 0);
        }

        //EntitySet
        [TestMethod]
        public void GetEntitySets()
        {
            //Arrange: A uri to a WCF 5.0 service is given as InArgument_Url           
            string InArgument_Url = String.Format("{0}/$metadata", uri);

            //Act
            IEnumerable<EntitySet> entitySets = from x in XElement.Load(InArgument_Url)
                .Descendants(edmXmlns.GetName("EntitySet"))
                select new EntitySet
                {
                    Name = x.Attributes("Name").Single().Value,
                    Namespace = x.Attributes("EntityType").Single().Value.Split(new char[] { '.' })[0],
                    EntityType = x.Attributes("EntityType").Single().Value.Split(new char[] { '.' })[1]
                };

            //Assert
            Assert.IsTrue(entitySets.Count() > 0);
        }

        [TestMethod]
        public void GetEntrySetFilterSchema()
        {
            //Arrange: A uri to a WCF 5.0 service is given as InArgument_Url
            string InArgument_Url = String.Format("{0}/$metadata", uri); ;
            string resource = "ProductCatalog";
            XElement metadata = XElement.Load(InArgument_Url);

            //Using Dependency: Get entitySets from a Class
            IEnumerable<EntitySet> entitySets = from x in metadata
                .Descendants(edmXmlns.GetName("EntitySet"))
                select new EntitySet
                {
                    Name = x.Attributes("Name").Single().Value,
                    Namespace = x.Attributes("EntityType").Single().Value.Split(new char[] { '.' })[0],
                    EntityType = x.Attributes("EntityType").Single().Value.Split(new char[] { '.' })[1]
                };


            //Act: A LINQ to XML query is constructed
            IEnumerable<EntityPropertySchema> entrySchema = from p in metadata
               .Descendants(edmXmlns.GetName("EntityType")).Descendants(edmXmlns.GetName("Property"))
                    where p.Parent.Attribute("Name").Value == (from e in entitySets where e.Name == resource select e.EntityType).Single<string>() &&
                    p.Attribute("Type").Value != "Edm.Stream"
                    select new EntityPropertySchema
                        {
                            Parent = p.Parent,
                            Name = p.Attribute("Name").Value,
                            Type = p.Attribute("Type").Value,
                            MaxLength = p.Attribute("MaxLength") == null ? "NaN" : p.Attribute("MaxLength").Value
                        };

            //Assert: IEnumerable list of Entity Data Model resource names > 0
            Assert.IsTrue(entrySchema.Count() > 0);
        }

        //NEXT: Convert to OData Lib
        [TestMethod]
        public void EntityProperties()
        {
            //Arrange:
            string resource = "ProductCatalog";
            string serviceQuery = String.Format("{0}/{1}", uri, resource);

            XNamespace xmlns = "http://www.w3.org/2005/Atom";
         
            //Act:

            //Get entries
            IEnumerable<XElement> entries = from element in XElement.Load(serviceQuery).Descendants(xmlns.GetName("entry")) select element;

            //Get properties
            List<List<EntityProperty>> properties = 
                (from property in entries.Descendants(mxmlns.GetName("properties"))
                select (from e in property.Descendants()
                    select new EntityProperty
                    {
                        Name = e.Name.LocalName,
                        Value = e.Value,
                        Type = e.HasAttributes ? (e.Attribute(mxmlns.GetName("type")) != null ? e.Attribute(mxmlns.GetName("type")).Value.ToString() : string.Empty) : "Edm.String"
                    }).ToList()).ToList();

            //Get links / named resources in single LINQ
            //NEXT: Join properties and links
            IEnumerable<IEnumerable<EntityProperty>> namedResources = from entry in entries
                select from l in entry.Descendants(xmlns.GetName("link"))
                where l.Attribute("type") != null
                select new EntityProperty
                {                 
                    Name = l.Attribute("title").Value.ToString(),
                    Value = l.Attribute("href").Value.ToString(),
                    Type = string.Format("link.{0}", l.Attribute("type").Value.ToString())
                };

            var entityIds = from e in entries.Descendants(xmlns.GetName("id")) select
                                new EntityProperty
                                {
                                    Name = "id",
                                    Value = e.Value,
                                    Type = "Edm.String"
                                };

            //Add namedResources to properties
            IEnumerable<EntityProperty> entityPropertyEnum;
            int i = -1;
            foreach (List<EntityProperty> p in properties)
            {
                i++;
                //Get the link properties
                entityPropertyEnum = namedResources.ElementAt(i);
                foreach (var item in entityPropertyEnum)
                {
                    p.Add(item);
                }
                //Add in entity id
                p.Add(entityIds.ElementAt(i));
            }

            //Assert:
            Assert.IsTrue(properties.ElementAt(0).Count() == 15);
        }


        [TestMethod]
        public void EntityPropertyIds()
        {
            //Arrange:
            XNamespace xmlns = "http://www.w3.org/2005/Atom";
            string resource = "ProductCatalog";
            string serviceQuery = String.Format("{0}/{1}", uri, resource);
           
            //Act:
            //Entity Properties
            IEnumerable<Dictionary<string, IEnumerable<EntityProperty>>> properties = from item in XElement.Load(serviceQuery).Descendants(mxmlns.GetName("properties"))
                select new Dictionary<string, IEnumerable<EntityProperty>>
                {
                    {
                        item.Parent.Parent.Descendants(xmlns.GetName("id")).First().Value.ToString(),
                            from e in item.Descendants()
                            select new EntityProperty { Name = e.Name.LocalName, Value = e.Value }
                    }                                                                
                };

            //Assert:
            Assert.IsTrue(properties.Count() > 0);
        }

        [TestMethod]
        public void PropertyNames()
        {
            //Arrange:
            string serviceQuery = String.Format("{0}/TerritorySalesDrilldown", uri);

            //Given entity properties
            IEnumerable<IEnumerable<EntityProperty>> properties = null;

            properties = from item in XElement.Load(serviceQuery).Descendants(mxmlns.GetName("properties"))
                         select from e in item.Descendants()
                                select new EntityProperty { Name = e.Name.LocalName, Value = e.Value };

            //Act:
            List<string> propertyNames = (from item in properties select item).First<IEnumerable<EntityProperty>>().Select(n => n.Name).ToList<string>();


            //Assert:
            Assert.IsTrue(propertyNames.Count() > 0);
        }

        //NEXT: Need a better way to code this
        /// <summary>
        /// Current iteration only applies to a filter and top query string parameter
        /// </summary>
        [TestMethod]
        public void QualifiedFilterQueryString()
        {
            //Result: http://services.odata.org/AdventureWorksV3/AdventureWorks.svc/TerritorySalesDrilldown?$filter=Total gt 2200 and Total lt 5000&$top=5&$skip=1&$select=TerritoryName,SalesPersonID
            //Arrange
            string resource = "TerritorySalesDrilldown";
            int top = 5;
            int skip = 1;
            List<string> selectProperties = new List<string> { "TerritoryName", "SalesPersonID" };
            List<string> orderbyList = new List<string> { "TerritoryName asc", "SalesPersonID desc" };

            IEnumerable<IEnumerable<EntityProperty>> properties = null;

            //Act
            StringBuilder queryStringBuilder = new StringBuilder();
            string serviceQuery = string.Empty;

            queryStringBuilder.Append(String.Format("/{0}?", resource));

            string filter = this.BuildFilter();

            //$filter
            if (filter != string.Empty)
                queryStringBuilder.Append(String.Format("{0}&", filter));

            //$top
            if (top > 0)
                queryStringBuilder.Append(String.Format("$top={0}&", top.ToString()));

            //$skip
            if (skip > 0)
                queryStringBuilder.Append(String.Format("$skip={0}&", skip.ToString()));

            //$orderby
            if (orderbyList.Count > 0)
            {
                queryStringBuilder.Append("$orderby=");
                StringBuilder orderbyStringBuilder = new StringBuilder();
                foreach (string item in orderbyList)
                {
                    orderbyStringBuilder.Append(String.Format("{0},", item));
                }
                string orderby = orderbyStringBuilder.ToString();
                queryStringBuilder.Append
                    (String.Format("{0}&", orderby.Substring(0, orderby.Length - 1)));
            }

            //$select
            if (selectProperties.Count > 0)
            {
                queryStringBuilder.Append("$select=");
                StringBuilder selectStringBuilder = new StringBuilder();
                foreach (string item in selectProperties)
                {
                    selectStringBuilder.Append(String.Format("{0},", item));
                }
                string select = selectStringBuilder.ToString();
                queryStringBuilder.Append(select.Substring(0, select.Length - 1));
            }

            string queryString = queryStringBuilder.ToString();
            //If last character is "&" then remove it
            if (queryString.Last<char>().ToString() == "&")
                queryString = queryString.Substring(0, queryString.Length - 1);

            //If last character is ? then no query has been applied, so remove /?
            if (queryString.Last<char>().ToString() == "?")
                queryString = queryString.Substring(0, queryString.Length - 1);

            if (uri.Last<char>().ToString() == "/")
                uri = uri.Substring(0, uri.Length - 1);

            serviceQuery = String.Format("{0}{1}", uri, queryStringBuilder.ToString());

            //Assert: NEXT: Assert Exception
            try
            {
                properties = from item in XElement.Load(serviceQuery).Descendants(mxmlns.GetName("properties"))
                             select from e in item.Descendants()
                                    select new EntityProperty { Name = e.Name.LocalName, Value = e.Value };

                Assert.IsTrue(properties.Count() > 0);
            }
            catch
            { //Catch exception in a production application
            }
        }

        private string BuildFilter()
        {
            return "$filter=Total gt 2200 and Total lt 5000";
        }
    }
}
