using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using MyBlog.Domain;
using System.Threading;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        public ActionResult Home()
        {
            return View();
        }


        public ActionResult AddBlog()
        {
            ViewBag.Success = false;
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    BlogCRUD.InsertBlog(new Data.Blog() { Title = blog.Title, Description = blog.Description, TStamp = DateTime.Now });
                    
                    ViewBag.BlogTitle = blog.Title;
                    ViewBag.Success = true;
                }
                catch (Exception ex)
                {
                    ViewBag.Success = false;
                    ViewBag.BlogException = ex.Message;
                }
            }
            else
            {
                ViewBag.Success = false;
            }
            return RedirectToAction("ShowAllBlogs", "Blog");
        }

        [HttpPost]
        public ActionResult DeleteBlog(int blogId)
        {
            if (blogId >= 0)
            {
                try
                {
                    BlogCRUD.DeleteBlog(blogId);
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                }
            }
            return RedirectToAction("ShowAllBlogs", "Blog");
        }
        
        public ActionResult ShowAllBlogs()
        {
            List<MyBlog.Models.Blog> blogs = BlogCRUD.SelectAll();
            return View(blogs);
        }
        

        public JsonResult BlogExists(string title)
        {
            if (BlogCRUD.CheckExists(title))
            {
                return Json("Blog already exists", JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }

    }
}
