namespace EntityFrameWork_CrudDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Book_PrimaryKey_and_Relations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookCategory", "BookId", "dbo.Book");
            DropForeignKey("dbo.BookPicture", "BookId", "dbo.Book");
            DropIndex("dbo.BookCategory", new[] { "BookId" });
            DropIndex("dbo.BookPicture", new[] { "BookId" });
            DropPrimaryKey("dbo.Book");
            AlterColumn("dbo.Book", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.BookCategory", "BookId", c => c.Int(nullable: false));
            AlterColumn("dbo.BookPicture", "BookId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Book", "Id");
            CreateIndex("dbo.BookCategory", "BookId");
            CreateIndex("dbo.BookPicture", "BookId");
            AddForeignKey("dbo.BookCategory", "BookId", "dbo.Book", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookPicture", "BookId", "dbo.Book", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookPicture", "BookId", "dbo.Book");
            DropForeignKey("dbo.BookCategory", "BookId", "dbo.Book");
            DropIndex("dbo.BookPicture", new[] { "BookId" });
            DropIndex("dbo.BookCategory", new[] { "BookId" });
            DropPrimaryKey("dbo.Book");
            AlterColumn("dbo.BookPicture", "BookId", c => c.String(maxLength: 128));
            AlterColumn("dbo.BookCategory", "BookId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Book", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Book", "Id");
            CreateIndex("dbo.BookPicture", "BookId");
            CreateIndex("dbo.BookCategory", "BookId");
            AddForeignKey("dbo.BookPicture", "BookId", "dbo.Book", "Id");
            AddForeignKey("dbo.BookCategory", "BookId", "dbo.Book", "Id");
        }
    }
}
