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
    
    public partial class BlogPost
    {
        public int PostID { get; set; }
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public System.DateTime TStamp { get; set; }
    
        public virtual Blog Blog { get; set; }
    }
}
