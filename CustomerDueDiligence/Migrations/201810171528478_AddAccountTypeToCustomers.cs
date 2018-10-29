namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountTypeToCustomers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "AccountTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "AccountTypeId");
            AddForeignKey("dbo.Customers", "AccountTypeId", "dbo.AccountTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AccountTypeId", "dbo.AccountTypes");
            DropIndex("dbo.Customers", new[] { "AccountTypeId" });
            DropColumn("dbo.Customers", "AccountTypeId");
            DropTable("dbo.AccountTypes");
        }
    }
}
