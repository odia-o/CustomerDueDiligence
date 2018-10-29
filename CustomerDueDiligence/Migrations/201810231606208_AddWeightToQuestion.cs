namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeightToQuestion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Weight", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "Weight");
        }
    }
}
