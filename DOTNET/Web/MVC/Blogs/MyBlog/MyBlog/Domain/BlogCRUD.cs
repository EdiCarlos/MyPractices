using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using MyBlog.Data;

namespace MyBlog.Domain
{
    public class BlogCRUD
    {
        public static void InsertBlog(Blog blog)
        {
            using (MyBlogEntities entities = new MyBlogEntities())
            {
                entities.Blogs.Add(blog);
                try
                {
                    entities.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static void DeleteBlog(int blogId)
        {
            using (MyBlogEntities entities = new MyBlogEntities())
            {
                try
                {
                    entities.Blogs.Remove(entities.Blogs.Where(e => e.BlogID == blogId).Select(e => e).First());
                    entities.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static bool CheckExists(string title)
        {
           bool result = false;
            using (MyBlogEntities entities = new MyBlogEntities())
            {
                if (entities.Blogs.Where(e => e.Title.ToLower().Equals(title)).Select(e => e).Count() > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        public static List<MyBlog.Models.Blog> SelectAll()
        {
            using (MyBlogEntities entities = new MyBlogEntities())
            {
                return entities.Blogs.Select(e => new MyBlog.Models.Blog() { Title = e.Title, Description = e.Description, BlogId = e.BlogID, CreationDate = e.TStamp}).OrderByDescending(e => e.CreationDate).ToList();
            }
        }
    }
}