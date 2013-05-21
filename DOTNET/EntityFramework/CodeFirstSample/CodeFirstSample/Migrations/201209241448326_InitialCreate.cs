namespace CodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Blog_BlogId = c.Int(),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogId)
                .Index(t => t.Blog_BlogId);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "Blog_BlogId" });
            DropForeignKey("dbo.Posts", "Blog_BlogId", "dbo.Blogs");
            DropTable("dbo.Blogs");
            DropTable("dbo.Posts");
        }
    }
}
