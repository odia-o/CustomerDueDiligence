namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AccountTypeId = c.Byte(nullable: false),
                        created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountTypes", t => t.AccountTypeId, cascadeDelete: true)
                .Index(t => t.AccountTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "AccountTypeId", "dbo.AccountTypes");
            DropIndex("dbo.Questions", new[] { "AccountTypeId" });
            DropTable("dbo.Questions");
        }
    }
}
