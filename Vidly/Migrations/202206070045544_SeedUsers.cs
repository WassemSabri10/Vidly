namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'330b7114-b163-472e-abf5-0d37e2ce64aa', N'guest@vidly.com', 0, N'ALcqoQ2GkHTIsqPps1vcIv4rgPqbT+HYsINs+crKG9FCCcFz5ZiuB2J6CkytWHLXpw==', N'321b213f-6ef2-4647-9a2c-56ec03e61c18', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6540945b-5b1d-430e-a1e2-2ff83e471f7b', N'admin@vidly.com', 0, N'ABAYfW145ZSAx3+x4OHOp9xolDwpIJA2VKM8scNIZyYR6jWQzggFcv4T+Lu/pzCpvw==', N'e693b53b-0dbc-4fbf-94eb-e471d4e0bdde', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2ad69d80-4b10-4106-be98-2190ac91cc1c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6540945b-5b1d-430e-a1e2-2ff83e471f7b', N'2ad69d80-4b10-4106-be98-2190ac91cc1c')

");
        }
        
        public override void Down()
        {
        }
    }
}
