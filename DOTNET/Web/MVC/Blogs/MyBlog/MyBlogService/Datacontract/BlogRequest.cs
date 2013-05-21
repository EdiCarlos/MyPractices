using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace MyBlogService.Datacontract
{
    //[DataContract]
    [MessageContract]
    public class BlogRequest
    {
        [MessageBodyMember]
        public List<Blog> Blog { get; set; }
        [MessageBodyMember]
        public UpdateBlog Update { get; set; }
        [MessageBodyMember]
        public DeleteBlog Delete { get; set; }
        [MessageBodyMember]
        public SelectBlog Select { get; set; }
        [MessageBodyMember]
        public SelectBlogs SelectBlogs { get; set; }
    }
}