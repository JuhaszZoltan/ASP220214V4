namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_custom_tables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ElofizetesTipusok", "Nev", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.Ugyfelek", "Nev", c => c.String(maxLength: 60, unicode: false));
            AlterColumn("dbo.Ugyfelek", "SzuletesiDatum", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ugyfelek", "SzuletesiDatum", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ugyfelek", "Nev", c => c.String(maxLength: 60));
            AlterColumn("dbo.ElofizetesTipusok", "Nev", c => c.String(maxLength: 10));
        }
    }
}
