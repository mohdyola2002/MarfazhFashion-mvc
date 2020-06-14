namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes DROP COLUMN Name");
        }
        
        public override void Down()
        {
        }
    }
}
