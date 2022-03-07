namespace ASP220214V4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updt_idenity_appuser_model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "JogositvanySzam", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "JogositvanySzam");
        }
    }
}
