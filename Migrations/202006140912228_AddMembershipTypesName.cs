namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes ADD Name nvarchar(50)");
        }
        
        public override void Down()
        {
        }
    }
}
