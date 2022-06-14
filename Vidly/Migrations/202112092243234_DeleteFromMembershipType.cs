namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFromMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from [dbo].[MembershipTypes] where id = 4");
        }

        public override void Down()
        {
        }
    }
}
