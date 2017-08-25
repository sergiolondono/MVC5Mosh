namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGeneros : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Generos",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);            
        }
        
        public override void Down()
        {            
            DropTable("dbo.Generos");
        }
    }
}
