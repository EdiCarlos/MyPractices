using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyBlogService.Datacontract
{
    [DataContract]
    public class Post
    {
        [DataMember]
        public int BlogID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember(IsRequired=true)]
        public string PostDetail{ get; set; }
    }
}