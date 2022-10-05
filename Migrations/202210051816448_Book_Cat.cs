namespace EntityFrameWork_CrudDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Book_Cat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookCategory", "BookId", "dbo.Book");
            DropForeignKey("dbo.BookCategory", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.BookPicture", "BookId", "dbo.Book");
            DropIndex("dbo.BookCategory", new[] { "BookId" });
            DropIndex("dbo.BookCategory", new[] { "CategoryId" });
            DropIndex("dbo.BookPicture", new[] { "BookId" });
            AddColumn("dbo.Book", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Book", "CategoryId");
            AddForeignKey("dbo.Book", "CategoryId", "dbo.Category", "Id", cascadeDelete: true);
            DropTable("dbo.BookCategory");
            DropTable("dbo.BookPicture");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookPicture",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PicturePath = c.String(),
                        PictureName = c.String(),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Book", "CategoryId", "dbo.Category");
            DropIndex("dbo.Book", new[] { "CategoryId" });
            DropColumn("dbo.Book", "CategoryId");
            CreateIndex("dbo.BookPicture", "BookId");
            CreateIndex("dbo.BookCategory", "CategoryId");
            CreateIndex("dbo.BookCategory", "BookId");
            AddForeignKey("dbo.BookPicture", "BookId", "dbo.Book", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookCategory", "CategoryId", "dbo.Category", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookCategory", "BookId", "dbo.Book", "Id", cascadeDelete: true);
        }
    }
}
