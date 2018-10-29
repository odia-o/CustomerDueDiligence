namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAccountTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AccountTypes (Id, Name, Description) VALUES (1, 'Individual', 'for normal customers')");
            Sql("INSERT INTO AccountTypes (Id, Name, Description) VALUES (2, 'Corporate', 'for corporate institutions')");
        }
        
        public override void Down()
        {
        }
    }
}
