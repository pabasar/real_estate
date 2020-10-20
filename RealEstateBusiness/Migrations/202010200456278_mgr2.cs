namespace RealEstateBusiness.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgr2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rent_tbl", "Rent1", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rent_tbl", "Rent1");
        }
    }
}
