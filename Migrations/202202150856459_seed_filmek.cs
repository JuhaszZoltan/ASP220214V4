namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_filmek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Filmek VALUES ('Felhőatlasz', 'Cloud Atlas', 2012, '~/Content/imgs/cover_imgs/cloud_atlas.jpg', 0);");
        }
        
        public override void Down()
        {
        }
    }
}
