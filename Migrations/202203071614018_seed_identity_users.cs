namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_identity_users : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'8aa064de-b8a2-4a1d-8245-e61b0d9052d6', N'admin@verebely.hu', 0, N'AM3qMxGl74acOX6UMQsJlOVjw5TH+j4Xv/wyf1MLKjar0Dk7oMGye8mWi/WUreuNFg==', N'a09a8a45-dd68-4913-a402-196fdafaa6f6', NULL, 0, 0, NULL, 1, 0, N'admin@verebely.hu')");
            Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'9bd3468c-daab-48d6-ad7e-39218affc761', N'user@verebely.hu', 0, N'AGNVYMw6ZNbMI/E/D8lTsFqCKwvAI3wpIKnkSjB9ZVoQ4uYJH3lYQ0ur7w4/sJO/QQ==', N'976755f6-4b45-4802-bbb2-eea1c0662eed', NULL, 0, 0, NULL, 1, 0, N'user@verebely.hu')");
            Sql("INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'333cf3ec-9eb9-4d93-b994-40d1cc62401d', N'KezelhetUgyfeleket')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'8aa064de-b8a2-4a1d-8245-e61b0d9052d6', N'333cf3ec-9eb9-4d93-b994-40d1cc62401d')");

            
        }

        public override void Down()
        {
        }
    }
}
