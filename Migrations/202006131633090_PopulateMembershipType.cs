namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name, MinimumOrder, DiscountRate) VALUES (1, 'Customer', 1, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, MinimumOrder, DiscountRate) VALUES (2, 'Retailer', 10, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
