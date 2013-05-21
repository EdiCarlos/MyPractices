using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace MyBlogService.Datacontract
{
    [MessageContract]
    public class BlogResponse
    {
        [MessageBodyMember]
        public DBResult Result;
        [MessageBodyMember]
        public Blog SingleBlog;

        [MessageBodyMember]
        public List<Blog> BlogList;
    }
}