namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCurtainsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curtains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Price = c.Int(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Curtains");
        }
    }
}
