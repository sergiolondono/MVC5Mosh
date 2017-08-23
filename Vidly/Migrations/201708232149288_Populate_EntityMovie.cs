namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate_EntityMovie : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) values ( 'Die Hard', 'Action', '20130101', '20140401', '6')");
            Sql("insert into Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) values ( 'The Terminator', 'Action', '20121025', '20150909', '25')");
            Sql("insert into Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) values ( 'Toy Story', 'Family', '20100125', '20110101', '30')");
            Sql("insert into Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) values ( 'Titanic', 'Romance', '20151102', '20170302', '50')"); 
        }
        
        public override void Down()
        {
        }
    }
}
