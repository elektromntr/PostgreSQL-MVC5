namespace PostgresTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jsonTagsProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Cars", "Tag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Cars", "Tag");
        }
    }
}
