namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_filmek_mufajok : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filmek",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EredetiCim = c.String(maxLength: 60, unicode: false),
                        MagyarCim = c.String(maxLength: 60, unicode: false),
                        MegjelenesiEv = c.Int(nullable: false),
                        Kep = c.String(maxLength: 60, unicode: false),
                        Korhataros = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mufajok",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Megnevezes = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.FilmMufajKapcsolo",
                c => new
                    {
                        FilmId = c.Int(nullable: false),
                        MufajId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FilmId, t.MufajId })
                .ForeignKey("dbo.Filmek", t => t.FilmId, cascadeDelete: true)
                .ForeignKey("dbo.Mufajok", t => t.MufajId, cascadeDelete: true)
                .Index(t => t.FilmId)
                .Index(t => t.MufajId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmMufajKapcsolo", "MufajId", "dbo.Mufajok");
            DropForeignKey("dbo.FilmMufajKapcsolo", "FilmId", "dbo.Filmek");
            DropIndex("dbo.FilmMufajKapcsolo", new[] { "MufajId" });
            DropIndex("dbo.FilmMufajKapcsolo", new[] { "FilmId" });
            DropTable("dbo.Mufajok");
            DropTable("dbo.FilmMufajKapcsolo");
            DropTable("dbo.Filmek");
        }
    }
}
