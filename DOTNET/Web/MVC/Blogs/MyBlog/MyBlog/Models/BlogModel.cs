using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        
        [Required(ErrorMessage="Title Cannot be Null")]
        [Display(Name="Title")]
        [Remote("BlogExists", "Blog", ErrorMessage="Blog already exists")]
        public string Title { get; set; }
        
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Description")]
        public DateTime CreationDate { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string BlogPost { get; set; }
        public DateTime PostDate { get; set; }
    }
}