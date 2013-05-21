using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace MyBlogService.Implementation
{
    [ServiceBehavior]
    public class BlogService : IBlogService
    {
        public static string GetConnectionStringEF()
        {
            EntityConnectionStringBuilder entityConnectionString = new EntityConnectionStringBuilder();
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder("data source=localhost;initial catalog=MyBlog;persist security info=True;user id=sa;password=andheri788;MultipleActiveResultSets=True;App=EntityFramework");

            entityConnectionString.ProviderConnectionString = sqlConnectionStringBuilder.ToString();
            entityConnectionString.Metadata = "res://*/MyBlog.csdl|res://*/MyBlog.ssdl|res://*/MyBlog.msl";
            entityConnectionString.Provider = "System.Data.SqlClient";
            return entityConnectionString.ToString();
        }

        public Datacontract.BlogResponse InsertBlog(Datacontract.BlogRequest request)
        {
            bool result = false;

            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {

                foreach (Datacontract.Blog blg in request.Blog)
                {
                    blog.Blogs.Add(new Blog() { Title = blg.Title, Description = blg.Description, TStamp = DateTime.Now });
                }
                try
                {
                    blog.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.BlogResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail };
        }

        public Datacontract.BlogResponse UpdateBlog(Datacontract.BlogRequest request)
        {
            bool result = false;
            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {

                Blog updateBlog = blog.Blogs.Where(e => e.BlogID == request.Update.BlogId).Select(e => e).First();
                updateBlog.Title = request.Update.Blog.Title;
                updateBlog.Description = request.Update.Blog.Description;

                try
                {
                    blog.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.BlogResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail };
        }

        public Datacontract.BlogResponse DeleteBlog(Datacontract.BlogRequest request)
        {
            bool result = false;
            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {

                Blog deleteBlog = blog.Blogs.Where(e => e.BlogID == request.Delete.BlogId).Select(e => e).First();
                blog.Blogs.Remove(deleteBlog);
                try
                {
                    blog.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.BlogResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail };
        }

        public Datacontract.BlogResponse SelectBlog(Datacontract.BlogRequest request)
        {
            if (request.Select.BlogId == null)
            {
                throw new Exception("BlogId must be defined");
            }
            Datacontract.BlogResponse response = new Datacontract.BlogResponse();

            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {

                response.SingleBlog = blog.Blogs.Where(e => e.BlogID == request.Select.BlogId).Select(e => new Datacontract.Blog() { Title = e.Title, Description = e.Description }).First();
            }
            return response;
        }

        public Datacontract.BlogResponse SelectBlogs(Datacontract.BlogRequest request)
        {
            Datacontract.BlogResponse response = new Datacontract.BlogResponse();
            if (request.SelectBlogs.BlogId == null && request.SelectBlogs.BlogId.Count() <= 0)
            {
                throw new Exception("Blog ids required to get blogs from SelectBlogs");
            }

            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {
                response.BlogList = blog.Blogs.Where(e => request.SelectBlogs.BlogId.Contains(e.BlogID)).Select(e => new Datacontract.Blog() { Title = e.Title, Description = e.Description }).ToList();
            }
            return response;
        }

        public Datacontract.PostResponse InsertPost(Datacontract.PostRequest request)
        {
            bool result = false;

            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {
                Datacontract.Post cPost = request.InsertPost;
                BlogPost post = new BlogPost();
                post.BlogID = cPost.BlogID;
                post.Email = cPost.Email;
                post.Name = cPost.Name;
                post.TStamp = DateTime.Now;
                post.Post = cPost.PostDetail;

                blog.BlogPosts.Add(post);

                try
                {
                    blog.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.PostResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail };

        }

        public Datacontract.PostResponse UpdatePost(Datacontract.PostRequest request)
        {
            bool result = false;

            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {
                Datacontract.Post cPost = request.UpdatePost;
                BlogPost post = blog.BlogPosts.Where(e => e.BlogID == cPost.BlogID).Select(e => e).FirstOrDefault();
                if (post != null)
                {
                    post.BlogID = cPost.BlogID;
                    post.Email = cPost.Email;
                    post.Name = cPost.Name;
                    post.TStamp = DateTime.Now;
                    post.Post = cPost.PostDetail;
                }
                try
                {
                    blog.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.PostResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail };
        }

        public Datacontract.PostResponse DeletePost(Datacontract.PostRequest request)
        {
            bool result = false;
            if (request.DeletePost.PostID == null && request.DeletePost.PostID.HasValue)
                throw new Exception("Post Id cannot be null");
            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {
                Datacontract.IPost cPost = request.DeletePost;

                BlogPost post = blog.BlogPosts.Where(e => e.BlogID == cPost.PostID).Select(e => e).FirstOrDefault();
                blog.BlogPosts.Remove(post);
                try
                {
                    blog.SaveChanges();
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.PostResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail };
        }

        public Datacontract.PostResponse SelectPost(Datacontract.PostRequest request)
        {
            bool result = false;
            Datacontract.PostResponse response = new Datacontract.PostResponse();

            if (request.DeletePost.PostID == null && request.DeletePost.PostID.HasValue)
                throw new Exception("Post Id cannot be null");

            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {
                try
                {

                    Datacontract.IPost cPost = request.DeletePost;

                    BlogPost post = blog.BlogPosts.Where(e => e.BlogID == cPost.PostID).Select(e => e).FirstOrDefault();
                    response.Post = new Datacontract.Post() { BlogID = post.BlogID, PostDetail = post.Post, Name = post.Name, Email = post.Email };

                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.PostResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail, Post = response.Post };
        }

        public Datacontract.PostResponse SelectPosts(Datacontract.PostRequest request)
        {
            bool result = false;
            Datacontract.PostResponse response = new Datacontract.PostResponse();

            if (request.SelectPost.PostID == null && request.DeletePost.PostID.HasValue)
                throw new Exception("Post Id cannot be null");

            using (MyBlogEntities blog = new MyBlogEntities(GetConnectionStringEF()))
            {
                try
                {
                    List<int> cPost = request.SelectPosts.PostIds;

                    response.Posts = blog.BlogPosts.Where(e => cPost.Contains(e.BlogID)).Select(e => new Datacontract.Post() { BlogID = e.BlogID, Name = e.Name, Email = e.Email, PostDetail = e.Post }).ToList();
                    
                    result = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return new Datacontract.PostResponse() { Result = result ? Datacontract.DBResult.Success : Datacontract.DBResult.Fail, Posts = response.Posts };
        }
    }
}