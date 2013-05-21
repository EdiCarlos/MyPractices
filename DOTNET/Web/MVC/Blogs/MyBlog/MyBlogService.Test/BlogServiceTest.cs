using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyBlogService.Test
{
    [TestClass]
    public class BlogServiceTest
    {
        [TestMethod]
        public void SelectBlogTest()
        {
        }

        [TestMethod]
        public void InserBlogTest()
        {
            MyBlogService.IBlogService blogService = new MyBlogService.Implementation.BlogService();
            Datacontract.BlogRequest request = new Datacontract.BlogRequest();
            request.Blog = new System.Collections.Generic.List<Datacontract.Blog>() { new Datacontract.Blog() { Title = "First1", Description = "First Description1" } };
            Datacontract.BlogResponse response = blogService.InsertBlog(request);
            if (response.Result == Datacontract.DBResult.Success)
            {
                Assert.AreEqual(true, true, "Objects are equal");
            }
            else
            {
                Assert.Fail("Insertion failed");
            }
        }
    }
}
