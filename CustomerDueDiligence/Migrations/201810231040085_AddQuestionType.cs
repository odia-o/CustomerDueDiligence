namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuestionTypes");
        }
    }
}
