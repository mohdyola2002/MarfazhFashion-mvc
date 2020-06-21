namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPurchaseClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatePurchased = c.DateTime(nullable: false),
                        Curtain_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curtains", t => t.Curtain_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Curtain_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Purchases", "Curtain_Id", "dbo.Curtains");
            DropIndex("dbo.Purchases", new[] { "Customer_Id" });
            DropIndex("dbo.Purchases", new[] { "Curtain_Id" });
            DropTable("dbo.Purchases");
        }
    }
}
