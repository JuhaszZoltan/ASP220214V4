namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_ugyfelek_2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ugyfelek", "Nev", c => c.String(nullable: false, maxLength: 60, unicode: false));
            AlterColumn("dbo.Ugyfelek", "SzuletesiDatum", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ugyfelek", "SzuletesiDatum", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Ugyfelek", "Nev", c => c.String(maxLength: 60, unicode: false));
        }
    }
}
