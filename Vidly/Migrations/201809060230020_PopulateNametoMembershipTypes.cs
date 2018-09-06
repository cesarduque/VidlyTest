namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNametoMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET NAME = 'A' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET NAME = 'B' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET NAME = 'C' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET NAME = 'D' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
