using MyBlogService.Datacontract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyBlogService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBlogService" in both code and config file together.
    [ServiceContract]
    public interface IBlogService
    {
        [OperationContract]
        BlogResponse InsertBlog(BlogRequest request);

        [OperationContract]
        BlogResponse UpdateBlog(BlogRequest request);

        [OperationContract]
        BlogResponse DeleteBlog(BlogRequest request);

        [OperationContract]
        BlogResponse SelectBlog(BlogRequest request);

        [OperationContract]
        BlogResponse SelectBlogs(BlogRequest request);

        [OperationContract]
        PostResponse InsertPost(PostRequest request);

        [OperationContract]
        PostResponse UpdatePost(PostRequest request);

        [OperationContract]
        PostResponse DeletePost(PostRequest request);

        [OperationContract]
        PostResponse SelectPost(PostRequest request);

        [OperationContract]
        PostResponse SelectPosts(PostRequest request);

    }
}
