namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionCategories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Type = c.String(),
                        Weight = c.Byte(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuestionCategories");
        }
    }
}
