namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_elofizetestipusok : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ElofizetesTipusok",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nev = c.String(maxLength: 10),
                        ElofizetoiDij = c.Int(nullable: false),
                        ElofizetettHonapokSzama = c.Int(nullable: false),
                        Kedvezmeny = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ElofizetesTipusok");
        }
    }
}
