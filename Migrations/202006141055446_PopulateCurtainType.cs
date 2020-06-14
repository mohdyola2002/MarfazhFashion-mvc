namespace MarfazahFashion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCurtainType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CurtainTypes (Name) VALUES ('Single')");
            Sql("INSERT INTO CurtainTypes (Name) VALUES ('Single with Net')");
            Sql("INSERT INTO CurtainTypes (Name) VALUES ('Pair')");
        }
        
        public override void Down()
        {
        }
    }
}
