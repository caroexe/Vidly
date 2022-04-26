namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'd9fc065c-5489-4a79-b710-1e43a69de8a5', N'admin@vidly.com', 0, N'ACsU7MLkUVbrXDlPDGvTR+72b0KKxchjVSDgDRlv+YWuyWhYBIiG08GPTmSLST/CzQ==', N'992ee9f7-ac3a-4e5d-90ec-13e4c4bf7875', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com', N'', N'')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'dbd2f26a-d306-4740-b396-459d855a7040', N'guest@vidly.com', 0, N'AD+jQJ0ewTasHQaUZahbsDip8ice6ruO1osOKssgbDVwl4NRyY8chLCNJi4l52ubXg==', N'15372a98-e213-4071-b138-aba63254ed29', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com', N'', N'')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'56735e15-488e-4a6c-a8b9-8dafbae305b7', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd9fc065c-5489-4a79-b710-1e43a69de8a5', N'56735e15-488e-4a6c-a8b9-8dafbae305b7')

");
        }
        
        public override void Down()
        {
        }
    }
}
