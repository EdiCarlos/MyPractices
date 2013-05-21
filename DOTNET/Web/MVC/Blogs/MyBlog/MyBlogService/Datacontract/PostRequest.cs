using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace MyBlogService.Datacontract
{
    [MessageContract]
    public class PostRequest
    {
        [MessageBodyMember]
        public Post InsertPost { get; set; }
        [MessageBodyMember]
        public Post UpdatePost { get; set; }
        [MessageBodyMember]
        public IPost DeletePost { get; set; }
        [MessageBodyMember]
        public IPost SelectPost { get; set; }
        [MessageBodyMember]
        public IPost SelectPosts { get; set; }

    }
    
    [DataContract]
    public class DeletePost : IPost
    {
        [DataMember]
        public int? PostID { get; set; }
        [DataMember]
        public List<int> PostIds { get; set; }
    }
    
    [DataContract]
    public class SelectPost : IPost
    {
        [DataMember]
        public int? PostID { get; set; }
        [DataMember]
        public List<int> PostIds { get; set; }
    }


    public interface IPost
    {
        int? PostID { get; set; }

        List<int> PostIds { get; set; }
    }
}