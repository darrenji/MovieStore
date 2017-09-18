namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
            Sql("UPDATE MembershipTypes SET MembershipName='Pay as You Go' WHERE Id= 1");
            Sql("UPDATE MembershipTypes SET MembershipName='Monthly' WHERE Id= 2");
            Sql("UPDATE MembershipTypes SET MembershipName='Quartely' WHERE Id= 3");
            Sql("UPDATE MembershipTypes SET MembershipName='Yearly' WHERE Id= 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipName");
        }
    }
}
