namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEntityMovie : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) values ( 'Hangover', 'Comedy', '20160101', '20170401', '4')");            
        }
        
        public override void Down()
        {
        }
    }
}
