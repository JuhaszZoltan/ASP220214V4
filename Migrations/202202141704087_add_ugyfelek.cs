namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_ugyfelek : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ugyfelek",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(maxLength: 60),
                        SzuletesiDatum = c.DateTime(nullable: false),
                        ElofizetesTipusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ElofizetesTipusok", t => t.ElofizetesTipusId, cascadeDelete: true)
                .Index(t => t.ElofizetesTipusId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ugyfelek", "ElofizetesTipusId", "dbo.ElofizetesTipusok");
            DropIndex("dbo.Ugyfelek", new[] { "ElofizetesTipusId" });
            DropTable("dbo.Ugyfelek");
        }
    }
}
