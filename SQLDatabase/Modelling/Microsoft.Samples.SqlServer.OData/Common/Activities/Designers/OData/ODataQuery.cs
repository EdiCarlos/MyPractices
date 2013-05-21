// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Samples.SqlServer.ExtensionMethods;
using System.Windows;

namespace Microsoft.Samples.SqlServer.Activities.Designers.OData
{
    public class EntityProperty
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public string Type { get; set; }
    }

    public class EntitySet
    {
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string EntityType { get; set; }
    }

    public class EntityPropertySchema
    {
        public XElement Parent { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string MaxLength { get; set; }
    }

    public class ODataQuery
    {
        private string uri = string.Empty;
        private XElement metadata = null;
        private XNamespace edmXmlns = "http://schemas.microsoft.com/ado/2009/11/edm";

        public ODataQuery(string endpointUrl)
        {
            uri = endpointUrl.RemoveQuotes();
            uri = uri.Trim().EndsWith(@"/") ? uri.Substring(0, uri.Length - 1) : uri;
            if (uri != string.Empty)
            {
                try
                {
                    metadata = XElement.Load(uri + "/$metadata");
                }
                catch (System.Net.WebException ex)
                {
                    //Show MessageBox for the sample. Log in a production application
                    MessageBox.Show(ex.Message, "QueryFeed Sample");
                }
            }
        }
        
        /// <summary>
        /// Get entity sets
        /// </summary>
        public IEnumerable<EntitySet> EntitySets
        {
            get
            {
                //Arrange: A uri to a WCF 5.0 service is given as InArgument_Url
                IEnumerable<EntitySet> entitySets = null;
                if (metadata != null)
                {
                    //Act: A LINQ to XML query is constructed that projects EntitySet XML to an EntitySet class
                    entitySets = from x in metadata
                        .Descendants(edmXmlns.GetName("EntitySet"))
                        select new EntitySet
                        {
                            Name = x.Attributes("Name").Single().Value,
                            Namespace = x.Attributes("EntityType").Single().Value.Split(new char[] { '.' })[0],
                            EntityType = x.Attributes("EntityType").Single().Value.Split(new char[] { '.' })[1]
                        };
                }

                //Return:
                return entitySets;
            }
        }

        /// <summary>
        ///  Get filter schema which does not include Edm.Stream
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public IEnumerable<EntityPropertySchema> FilterSchema(string resource)
        {
            IEnumerable<EntityPropertySchema> entitySchema = null;
            if (resource != string.Empty && metadata != null)
            {
                entitySchema = from p in metadata
                   .Descendants(edmXmlns.GetName("EntityType")).Descendants(edmXmlns.GetName("Property"))
                    where p.Parent.Attribute("Name").Value == (from e in this.EntitySets where e.Name == resource select e.EntityType).Single<string>()
                    && p.Attribute("Type").Value != "Edm.Stream"
                    select new EntityPropertySchema
                    {
                        Parent = p.Parent,
                        Name = p.Attribute("Name").Value,
                        Type = p.Attribute("Type").Value,
                        MaxLength = p.Attribute("MaxLength") == null ? "NaN" : p.Attribute("MaxLength").Value
                    };
            }

            return entitySchema;
        }

        /// <summary>
        ///  Get select schema which includes Edm.Stream
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public IEnumerable<EntityPropertySchema> SelectSchema(string resource)
        {
            IEnumerable<EntityPropertySchema> entitySchema = null;
            if (resource != string.Empty && metadata != null)
            {
                entitySchema = from p in metadata
                   .Descendants(edmXmlns.GetName("EntityType")).Descendants(edmXmlns.GetName("Property"))
                               where p.Parent.Attribute("Name").Value == (from e in this.EntitySets where e.Name == resource select e.EntityType).Single<string>()
                               select new EntityPropertySchema
                               {
                                   Parent = p.Parent,
                                   Name = p.Attribute("Name").Value,
                                   Type = p.Attribute("Type").Value,
                                   MaxLength = p.Attribute("MaxLength") == null ? "NaN" : p.Attribute("MaxLength").Value
                               };
            }

            return entitySchema;
        }

        /// <summary>
        /// Get the named resource (Edm.Stream) schema
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public IEnumerable<EntityPropertySchema> NamedResourceSchema(string resource)
        {
            IEnumerable<EntityPropertySchema> entitySchema = null;
            if (resource != string.Empty && metadata != null)
            {
                entitySchema = from p in metadata
                   .Descendants(edmXmlns.GetName("EntityType")).Descendants(edmXmlns.GetName("Property"))
                               where p.Parent.Attribute("Name").Value == (from e in this.EntitySets where e.Name == resource select e.EntityType).Single<string>() &&
                               p.Attribute("Type").Value == "Edm.Stream"
                               select new EntityPropertySchema
                               {
                                   Parent = p.Parent,
                                   Name = p.Attribute("Name").Value,
                                   Type = p.Attribute("Type").Value,
                                   MaxLength = p.Attribute("MaxLength") == null ? "NaN" : p.Attribute("MaxLength").Value
                               };
            }

            return entitySchema;
        }
    }
}
