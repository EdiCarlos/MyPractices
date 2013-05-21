using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace MyBlogService.Datacontract
{
    [MessageContract]
    public class PostResponse
    {
        [MessageBodyMember]
        public DBResult Result { get; set; }
        [MessageBodyMember]
        public Post Post { get; set; }
        [MessageBodyMember]
        public List<Post> Posts { get; set; }
    }
}