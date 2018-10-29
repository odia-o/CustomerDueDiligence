namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRAM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RAMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountTypeId = c.Byte(nullable: false),
                        QuestionCategoryId = c.Byte(nullable: false),
                        MinScore = c.Int(nullable: false),
                        MaxScore = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeId, cascadeDelete: true)
                .ForeignKey("dbo.QuestionCategories", t => t.QuestionCategoryId, cascadeDelete: true)
                .Index(t => t.AccountTypeId)
                .Index(t => t.QuestionCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RAMs", "QuestionCategoryId", "dbo.QuestionCategories");
            DropForeignKey("dbo.RAMs", "AccountTypeId", "dbo.AccountTypes");
            DropIndex("dbo.RAMs", new[] { "QuestionCategoryId" });
            DropIndex("dbo.RAMs", new[] { "AccountTypeId" });
            DropTable("dbo.RAMs");
        }
    }
}
