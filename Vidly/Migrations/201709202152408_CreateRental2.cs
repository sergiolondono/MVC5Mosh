namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRental2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "MyProperty", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "DateRented");
        }
    }
}
