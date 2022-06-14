namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFromMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from [dbo].[MembershipTypes] where id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
