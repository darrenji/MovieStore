namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
        }
    }
}
