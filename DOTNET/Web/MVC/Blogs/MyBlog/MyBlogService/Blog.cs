//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBlogService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public Blog()
        {
            this.BlogPosts = new HashSet<BlogPost>();
        }
    
        public int BlogID { get; set; }
        public string Title { get; set; }
        public System.DateTime TStamp { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }
}
