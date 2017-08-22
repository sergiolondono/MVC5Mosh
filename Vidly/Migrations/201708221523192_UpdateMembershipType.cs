namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {

            Sql("update MembershipTypes set Name='Pay as You Go' where Id=1"); 
            Sql("update MembershipTypes set Name='Monthly' where Id=2"); 
            Sql("update MembershipTypes set Name='quarterly' where Id=3");
            Sql("update MembershipTypes set Name='annual' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
