using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Domain;
using MyBlog.Data;
using md = MyBlog.Models;
namespace MyBlog.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/
        public ActionResult GetAllPost(int blogId, string blogtitle)
        {
            using (MyBlogEntities entities = new MyBlogEntities())
            {
                if (string.IsNullOrEmpty(blogtitle))
                    blogtitle = entities.Blogs.Where(e => e.BlogID == blogId).Select(e => e.Title).First();
                
                ViewBag.Title = blogtitle;

                List<md.Post> postList = entities.BlogPosts.Where(e => e.BlogID == blogId).OrderByDescending(e => e.TStamp).Select(e => new md.Post()
                 {
                     BlogId = e.BlogID,
                     PostId = e.PostID,
                     Name = e.Name,
                     Email = e.Email,
                     BlogPost = e.Post,
                     PostDate = e.TStamp
                 }).ToList();
    
                if (postList.Count() >= 1)
                {
                    ViewBag.Message = "";
                    ViewData.Add("blogId", blogId);
                    ViewData.Add("blogtitle", blogtitle);
                    return View(postList);
                }
                else
                {
                    ViewBag.Message = "No Post Found for blog name \"" + blogtitle + "\"";
                    ViewData.Add("blogId", blogId);
                    ViewData.Add("blogtitle", blogtitle);
                    return View();
                }
            }
        }

        [HttpPost]
        public ActionResult InsertPost(Models.Post post, int blogId, string blogtitle)
        {
            using (MyBlogEntities entities = new MyBlogEntities())
            {
                entities.BlogPosts.Add(new BlogPost()
                {
                    BlogID = blogId,
                    Email = post.Email,
                    Name = post.Name,
                    Post = post.BlogPost,
                    TStamp = DateTime.Now
                });

                try
                {
                    entities.SaveChanges();
                    return RedirectToAction("GetAllPost", new { blogId = blogId, blogtitle = blogtitle });
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        [HttpPost]
        public ActionResult DeletePost(int blogId, string blogtitle, int postId)
        {
            using (MyBlogEntities entities = new MyBlogEntities())
            {
                BlogPost blogPost = entities.BlogPosts.Where(e => e.PostID == postId).Select(e => e).First();
                if (blogPost != null)
                {
                    entities.BlogPosts.Remove(blogPost);
                    entities.SaveChanges();
                }
            }
            return RedirectToAction("GetAllPost", "Post", new { blogId = blogId, blogtitle = blogtitle });
        }
    }
}
