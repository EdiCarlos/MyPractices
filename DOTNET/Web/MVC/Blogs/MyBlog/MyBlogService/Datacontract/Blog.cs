using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyBlogService.Datacontract
{
    [DataContract]
    public class Blog
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
    
    [DataContract]
    public class UpdateBlog
    {
        [DataMember]
        public Blog Blog { get; set; }
        [DataMember]
        public int BlogId { get; set; }
    }

    [DataContract]
    public class SelectBlog
    {
        [DataMember]
        public int BlogId { get; set; }
    }
    [DataContract]
    public class SelectBlogs
    {
        [DataMember]
        public List<int> BlogId { get; set; }
    }

    [DataContract]
    public class DeleteBlog
    {
        [DataMember]
        public int BlogId { get; set; }
    }

    [DataContract]
    public enum DBResult
    {
        [EnumMember]
        Success,
        [EnumMember]
        Fail
    }
}