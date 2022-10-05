namespace EntityFrameWork_CrudDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookAuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookAuthor", t => t.BookAuthorId, cascadeDelete: true)
                .Index(t => t.BookAuthorId);
            
            CreateTable(
                "dbo.BookAuthor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.String(maxLength: 128),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Book", t => t.BookId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookPicture",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PicturePath = c.String(),
                        PictureName = c.String(),
                        BookId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Book", t => t.BookId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookPicture", "BookId", "dbo.Book");
            DropForeignKey("dbo.BookCategory", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.BookCategory", "BookId", "dbo.Book");
            DropForeignKey("dbo.Book", "BookAuthorId", "dbo.BookAuthor");
            DropIndex("dbo.BookPicture", new[] { "BookId" });
            DropIndex("dbo.BookCategory", new[] { "CategoryId" });
            DropIndex("dbo.BookCategory", new[] { "BookId" });
            DropIndex("dbo.Book", new[] { "BookAuthorId" });
            DropTable("dbo.BookPicture");
            DropTable("dbo.Category");
            DropTable("dbo.BookCategory");
            DropTable("dbo.BookAuthor");
            DropTable("dbo.Book");
        }
    }
}
