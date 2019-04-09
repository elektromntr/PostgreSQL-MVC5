namespace PostgresTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carsExtended : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Cars", "HorsePower", c => c.Int(nullable: false));
            AddColumn("public.Cars", "EngineCapacity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("public.Cars", "EngineCapacity");
            DropColumn("public.Cars", "HorsePower");
        }
    }
}
