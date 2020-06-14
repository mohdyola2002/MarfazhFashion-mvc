namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCurtainType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurtainTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Curtains", "CurtainTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Curtains", "CurtainTypeId");
            AddForeignKey("dbo.Curtains", "CurtainTypeId", "dbo.CurtainTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curtains", "CurtainTypeId", "dbo.CurtainTypes");
            DropIndex("dbo.Curtains", new[] { "CurtainTypeId" });
            DropColumn("dbo.Curtains", "CurtainTypeId");
            DropTable("dbo.CurtainTypes");
        }
    }
}
