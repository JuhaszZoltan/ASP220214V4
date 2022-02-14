namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_elofizetestipusok : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ElofizetesTipusok VALUES (1, 'Bronze', 0, 0, 0);");
            Sql("INSERT INTO ElofizetesTipusok VALUES (2, 'Silver', 1500, 1, 5);");
            Sql("INSERT INTO ElofizetesTipusok VALUES (3, 'Gold', 8000, 6, 10);");
            Sql("INSERT INTO ElofizetesTipusok VALUES (4, 'Platinum', 15000, 12, 20);");
        }
        
        public override void Down()
        {
        }
    }
}
