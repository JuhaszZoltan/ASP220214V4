namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_ugyfelek : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ugyfelek", "HirlevelFeliratkozas", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ugyfelek", "HirlevelFeliratkozas");
        }
    }
}
