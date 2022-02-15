namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_film_mufaj_kapcsolo : DbMigration
    {
        public override void Up()
        {
            //Cloud Atlas
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (1, 1);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (1, 2);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (1, 3);");
            //The Matrix
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (2, 3);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (2, 4);");
            // The Prestige
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (3, 1);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (3, 2);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (3, 6);");
            //Dune
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (4, 3);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (4, 4);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (4, 7);");
            //Kill Bill: Vol. 1
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (5, 1);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (5, 4);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (5, 5);");
            //One Flew Over the Cuckoo's Nest
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (6, 1);");
            //Fight Club
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (7, 1);");
            //Twelve Monkeys
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (8, 2);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (8, 3);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (8, 6);");
            //Metropolis
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (9, 1);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (9, 3);");
            //True Romance
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (10, 1);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (10, 5);");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (10, 8);");
            //Predestination
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (11, 1)");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (11, 3)");
            Sql("INSERT INTO FilmMufajKapcsolo VALUES (11, 4)");
        }

        public override void Down()
        {
        }
    }
}
