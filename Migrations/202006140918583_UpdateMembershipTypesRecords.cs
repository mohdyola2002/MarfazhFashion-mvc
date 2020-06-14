namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypesRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Customer' WHERE DiscountRate = 0");
            Sql("UPDATE MembershipTypes SET Name = 'Retailer' WHERE DiscountRate = 10");
        }
        
        public override void Down()
        {
        }
    }
}
