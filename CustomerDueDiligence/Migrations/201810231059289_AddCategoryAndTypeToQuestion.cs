namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryAndTypeToQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "QuestionCategoryId", c => c.Byte(nullable: false));
            AddColumn("dbo.Questions", "QuestionTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Questions", "QuestionCategoryId");
            CreateIndex("dbo.Questions", "QuestionTypeId");
            AddForeignKey("dbo.Questions", "QuestionCategoryId", "dbo.QuestionCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Questions", "QuestionTypeId", "dbo.QuestionTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "QuestionTypeId", "dbo.QuestionTypes");
            DropForeignKey("dbo.Questions", "QuestionCategoryId", "dbo.QuestionCategories");
            DropIndex("dbo.Questions", new[] { "QuestionTypeId" });
            DropIndex("dbo.Questions", new[] { "QuestionCategoryId" });
            DropColumn("dbo.Questions", "QuestionTypeId");
            DropColumn("dbo.Questions", "QuestionCategoryId");
        }
    }
}
