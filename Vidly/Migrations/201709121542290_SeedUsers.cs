namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'980168eb-48eb-4441-aa60-f4879a7bab1d', N'fullAdminVidly', N'AAG8hWxp+bwy3PggRdA0FypvaIOP/YDmdiYq7lu/a342nv8LlityPBZEgI0J9FOn4w==', N'43621032-56bc-4af8-bf6c-3ce1d4e783f6', N'ApplicationUser')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'cd48f7c4-297b-4415-8e1f-13cd56164618', N'adminvidly', N'APU4UQTgJWRDBsmTVqKWvqlqDtgmKg3Kzng8OysgRDrPyJTfH3P+3QIhvPxsf9WBKg==', N'e745f28a-943f-470c-9a36-e707af54c6ce', N'ApplicationUser')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ed3232d5-56a8-4f12-be9c-f0e21cc6c036', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'980168eb-48eb-4441-aa60-f4879a7bab1d', N'ed3232d5-56a8-4f12-be9c-f0e21cc6c036')


");
        }
        
        public override void Down()
        {
        }
    }
}
