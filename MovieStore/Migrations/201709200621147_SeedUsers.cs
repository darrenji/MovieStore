namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'891cc4ca-a0a0-4dee-a17a-e9bb887bbc64', N'guest@moviestore.com', 0, N'AL1lfSQGFp7APKTnoQ+y81kn+cx/DrcLqpPk+MqmgVFTHiqkek/J1AA1AadenibeCw==', N'8eb0895f-2310-4104-ae7b-3f7dbe3e4488', NULL, 0, 0, NULL, 1, 0, N'guest@moviestore.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd268d52-c387-4359-b3c5-6d83e11566f8', N'admin@moviestore.com', 0, N'AGw8wavPsit+8jhIX/His8j43yxe9A3WYkWD1JgWuzh1cLCBte+8fwWVg8IWfHX4Zw==', N'84945f10-bd82-4596-a4ac-a3bf88c072fb', NULL, 0, 0, NULL, 1, 0, N'admin@moviestore.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'38871df1-1080-478e-a0bc-7b021cc5b032', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fd268d52-c387-4359-b3c5-6d83e11566f8', N'38871df1-1080-478e-a0bc-7b021cc5b032')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
