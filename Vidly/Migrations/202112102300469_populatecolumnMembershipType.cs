namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatecolumnMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update [dbo].[MembershipTypes] set [MembershipType] ='Pay as You Go' where Id = 1");
            Sql("Update [dbo].[MembershipTypes] set [MembershipType] = 'Monthly' where Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
