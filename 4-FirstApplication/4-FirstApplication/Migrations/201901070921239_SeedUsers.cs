namespace _4_FirstApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'38d6165f-a689-42ef-8d47-c40262cdf798', N'admin@gmail.com', 0, N'AKOZoJEE6RCgsZxDWYq9dFYi6/P4krKdwgb8lWyarNuD3R9cKr+xRPXhM0V1arhf2Q==', N'1d3cf37a-4b6c-42e9-ba4b-ef1f9ec79ea1', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c507f5bf-23a6-40bc-828a-d587175787a7', N'guest@gmail.com', 0, N'APghiLesERgCMWRqxCEW4SDWPUE6tIOCckRLlEMbDuTtOEDpsv8kKUgaRK6yIVU2TQ==', N'1dd91b85-6541-4da6-b5ac-33f5b04407e4', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'832ea40b-2dbe-440d-835d-89783edc10da', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'38d6165f-a689-42ef-8d47-c40262cdf798', N'832ea40b-2dbe-440d-835d-89783edc10da')
                
"
               );
        }
        
        public override void Down()
        {
        }
    }
}
