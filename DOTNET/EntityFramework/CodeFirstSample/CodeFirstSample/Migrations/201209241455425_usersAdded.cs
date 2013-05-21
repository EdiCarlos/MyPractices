namespace CodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usersAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.Username);
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
