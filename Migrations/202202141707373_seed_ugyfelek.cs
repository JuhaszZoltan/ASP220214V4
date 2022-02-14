namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed_ugyfelek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ugyfelek VALUES ('Csorba Edina',       '1985-11-15', 1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Gárdonyi Cili',      '1987-11-30', 1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Seres Krisztofer',   '1989-06-06', 2);");
            Sql("INSERT INTO Ugyfelek VALUES ('Bartha Ödön',        '1994-09-06', 1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Bognár Vivien',      '1996-07-08', 4);");
            Sql("INSERT INTO Ugyfelek VALUES ('Sólyom András ',     '1999-08-06', 3);");
            Sql("INSERT INTO Ugyfelek VALUES ('Jakab Mari',         '2001-12-14', 1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Fehér Alexander',    '2009-02-20', 3);");
            Sql("INSERT INTO Ugyfelek VALUES ('Gáspár Szilveszter', '2010-10-16', 1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Mátyás Virág',       '2011-11-07', 2);");
        }
        
        public override void Down()
        {
        }
    }
}
