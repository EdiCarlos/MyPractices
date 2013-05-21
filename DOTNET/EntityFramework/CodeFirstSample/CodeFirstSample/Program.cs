using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
                Console.WriteLine("Enter Blog Name ...");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                var query = from d in db.Blogs orderby d.Name select d;
                Console.WriteLine("All the console blogs...");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual Blog Blog { get; set; }
    }
    public class User
    {
        [Key]
        [MaxLength(50)]
        public string Username { get; set; }
        public string EmailAddress { get; set; }
    }
    public class Address
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
    public class FullAddress
    {
        [ForeignKey("AddressId")]
        public int AddressId { get; set; }
        public string Addresses { get; set; }
    }

    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Address> Address { get; set; }
        //public DbSet<FullAddress> FullAddress { get; set; }
    }

}
