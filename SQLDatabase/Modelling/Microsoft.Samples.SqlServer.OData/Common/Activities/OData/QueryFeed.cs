// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Xml.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.Activities;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using Microsoft.Samples.SqlServer.ExtensionMethods;

//NOTE: AsyncCodeActivity is not implemented since it does not support child activities
namespace Microsoft.Samples.SqlServer.Activities
{
    [Designer(typeof(Microsoft.Samples.SqlServer.Activities.Designers.QueryFeedDesigner))]
    public sealed class QueryFeed : NativeActivity
    {
        public string Uri { get; set; }
        public string Resource { get; set; }

        //Filter
        public InArgument<int> Top { get; set; }
        public InArgument<int> Skip { get; set; }
        [Browsable(false)]
        public Collection<Activity> FilterActivities { get; set; }

        public List<string> OrderBy { get; set; }
        public List<string> SelectProperties { get; set; }
        public List<string> NamedResources { get; set; }

        public OutArgument<string> ServiceQueryString { get; set; }
        public OutArgument<IEnumerable<IEnumerable<EntityProperty>>> EntityProperties { get; set; }
        
        //Drop Activities
        public QueryFeed()
        {
          FilterActivities = new Collection<Activity>();
        }

        //Cache composite activity metadata
        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {
            metadata.SetChildrenCollection(FilterActivities);

            base.CacheMetadata(metadata);
        }

        /// <summary>
        /// Execute the activity returning the service query and entity properties
        /// </summary>
        /// <param name="context"></param>
        protected override void Execute(NativeActivityContext context)
        {
            List<List<EntityProperty>> properties = null;
            XNamespace mxmlns = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata";
            XNamespace xmlns = "http://www.w3.org/2005/Atom";

            string serviceQuery = this.QualifiedFilterQueryString
                (this.Uri.RemoveQuotes(), this.Resource.RemoveQuotes(), context.GetValue<int>(this.Top), context.GetValue<int>(this.Skip), 
                this.SelectProperties, this.OrderBy);

            try
            {
                IEnumerable<XElement> entries = from element in XElement.Load(serviceQuery).Descendants(xmlns.GetName("entry")) select element;

                properties =
                    (from property in entries.Descendants(mxmlns.GetName("properties"))
                     select (from e in property.Descendants()
                             select new EntityProperty
                             {
                                 Name = e.Name.LocalName,
                                 Value = e.Value,
                                 Type = e.HasAttributes ? (e.Attribute(mxmlns.GetName("type")) != null ? e.Attribute(mxmlns.GetName("type")).Value.ToString() : string.Empty) : "Edm.String"
                             }).ToList()).ToList();

                //NEXT: Join properties and links using a single LINQ statement
                IEnumerable<IEnumerable<EntityProperty>> namedResources = from entry in entries
                    select from l in entry.Descendants(xmlns.GetName("link"))
                            where l.Attribute("type") != null
                            select new EntityProperty
                            {
                                Name = l.Attribute("title").Value.ToString(),
                                Value = l.Attribute("href").Value.ToString(),
                                Type = "Edm.Stream"
                            };

                var entityIds = from e in entries.Descendants(xmlns.GetName("id"))
                            select
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
            }
            catch 
            { 
                // Catch exception in a production application
            }

            ServiceQueryString.Set(context, serviceQuery);
            EntityProperties.Set(context, properties);
        }

        /// <summary>
        /// Build a qualified OData query string
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="resource"></param>
        /// <param name="top"></param>
        /// <param name="skip"></param>
        /// <param name="selectProperties"></param>
        /// <returns></returns>    
        private string QualifiedFilterQueryString(string uri, string resource, int top, int skip, 
            List<string> selectProperties, List<string> orderbyList)
        {
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

            serviceQuery = String.Format("{0}{1}", uri, queryString);

            return serviceQuery;
        }
        
        /// <summary>
        /// Build $filter
        /// </summary>
        /// <returns></returns>
        private string BuildFilter()
        {
            StringBuilder filterStringBuilder = new StringBuilder();

            if (this.FilterActivities.Count > 0)
            {
                filterStringBuilder.Append("$filter=");

                //Build
                foreach (Filter activity in this.FilterActivities)
                {

                    filterStringBuilder.Append(String.Format("{0} {1} {2}",
                        activity.Name.ToString(), 
                        activity.ComparisonOperator.ToString().ToLower(), 
                        activity.Value.ToString().Replace("\"", "'")));
                    if (activity.LogicalOperator != LogicalOperatorEnum.End)
                        filterStringBuilder.Append(
                        String.Format(" {0} ", activity.LogicalOperator.ToString().ToLower()));
                }
            }

            return filterStringBuilder.ToString();
        }
    }
}
