namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_mufajok : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Mufajok VALUES (1, 'Drama');");
            Sql("INSERT INTO Mufajok VALUES (2, 'Mystery');");
            Sql("INSERT INTO Mufajok VALUES (3, 'Sci-Fi');");
            Sql("INSERT INTO Mufajok VALUES (4, 'Action');");
            Sql("INSERT INTO Mufajok VALUES (5, 'Crime');");
            Sql("INSERT INTO Mufajok VALUES (6, 'Thriller');");
            Sql("INSERT INTO Mufajok VALUES (7, 'Adventure');");
            Sql("INSERT INTO Mufajok VALUES (8, 'Romance');");
        }
        
        public override void Down()
        {
        }
    }
}
