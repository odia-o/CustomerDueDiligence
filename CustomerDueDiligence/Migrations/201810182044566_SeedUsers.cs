namespace CustomerDueDiligence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'91ec3a06-d6f8-49f9-b1f6-fcc5babdfe45', N'admin@cdd.com', 0, N'AH9KfCirMIDp8RYWbGbE1M/dsWv9pAvq7Xq19noWsPwPprB2fCSXqfVGyrIe666oPg==', N'2cf2961f-a788-46e4-b856-1195728000ff', NULL, 0, 0, NULL, 1, 0, N'admin@cdd.com')
INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'b75bb57e-a21f-492f-a504-810a70bf9cbf', N'guest@cdd.com', 0, N'AJ9esfl2Gr/ZrMHURIZ6mJTDZ1Dp/Ctk1tJKYn2se2B8F+cpe53wcbiLo5obZY9Irg==', N'8d535179-2a68-4039-9dec-ad2b42ebdfd8', NULL, 0, 0, NULL, 1, 0, N'guest@cdd.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bc2f6763-f107-4e83-a070-13a194f15ed9', N'CanManageCustomers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'91ec3a06-d6f8-49f9-b1f6-fcc5babdfe45', N'bc2f6763-f107-4e83-a070-13a194f15ed9')

");
        }
        
        public override void Down()
        {
        }
    }
}
