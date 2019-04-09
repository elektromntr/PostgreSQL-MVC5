namespace PostgresTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Cars",
                c => new
                    {
                        LicenseNumber = c.Int(nullable: false, identity: true),
                        Insurance = c.String(),
                        Year = c.Int(),
                    })
                .PrimaryKey(t => t.LicenseNumber);
            
        }
        
        public override void Down()
        {
            DropTable("public.Cars");
        }
    }
}
