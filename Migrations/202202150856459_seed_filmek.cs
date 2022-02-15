namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_filmek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Filmek VALUES ('Cloud Atlas',                        'Felhőatlasz',             2012, 'cloud_atlas_ci.jpg',    0);");
            Sql("INSERT INTO Filmek VALUES ('The Matrix',                         'Mátrix',                  1999, 'matrix_ci.jpg',         0);");
            Sql("INSERT INTO Filmek VALUES ('The Prestige',                       'A tökéletes trükk',       2006, 'prestige_ci.jpg',       0);");
            Sql("INSERT INTO Filmek VALUES ('Dune',                               'Dűne',                    1984, 'dune_84_ci.jpg',        0);");
            Sql("INSERT INTO Filmek VALUES ('Kill Bill',                          'Kill Bill',               2003, 'kill_bill_ci.jpg',      1);");
            Sql("INSERT INTO Filmek VALUES ('One Flew Over the Cuckoo&#39s Nest', 'Száll a kakukk fészkére', 1975, 'cuckoos_nest_ci.jpg',   0);");
            Sql("INSERT INTO Filmek VALUES ('Fight Club',                         'Harcosok klubja',         1999, 'fight_club_ci.jpg',     0);");
            Sql("INSERT INTO Filmek VALUES ('Twelve Monkeys',                     '12 majom',                1995, 'twelve_monkeys_ci.jpg', 0);");
            Sql("INSERT INTO Filmek VALUES ('Metropolis',                         'Metropolis',              1927, 'metropolis_ci.jpg',     0);");
            Sql("INSERT INTO Filmek VALUES ('True Romance',                       'Tiszta románc',           1993, 'true_romance_ci.jpg',   0);");
        }
        
        public override void Down()
        {
        }
    }
}
