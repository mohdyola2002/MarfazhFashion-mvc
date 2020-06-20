namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0bc99127-640f-4869-af69-f9fa5979ec2e', N'guest@marfazhfashion.com', 0, N'AIbyLZwvKq1Wx6pYONeOC+1YWCjpHCpK0Jqn6ItOnXL7ZZRLKS88jyBbfTOsBgvkUA==', N'a1a69a21-5505-4402-8892-6d4657eb94d2', NULL, 0, 0, NULL, 1, 0, N'guest@marfazhfashion.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b346c6d6-228e-49ec-8730-6caf9b816215', N'admin@marfazhfashion.com', 0, N'AAfwv2vq7RDLsgLr/NXPq1EkSErsRzRp65Bp00RqzbPx+/X/PtbEm/8ZUe/+n7MuiA==', N'b333da25-2e9e-4eb3-85d6-953b6e36dcde', NULL, 0, 0, NULL, 1, 0, N'admin@marfazhfashion.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4e2befee-6c24-4713-a8dc-f04c71c39ac1', N'CanManageCurtains')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b346c6d6-228e-49ec-8730-6caf9b816215', N'4e2befee-6c24-4713-a8dc-f04c71c39ac1')

");
        }
        
        public override void Down()
        {
        }
    }
}
