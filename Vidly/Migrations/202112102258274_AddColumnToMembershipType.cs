namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE [dbo].[MembershipTypes] ADD MembershipType nvarchar(255); "); 
        }
        
        public override void Down()
        {
        }
    }
}
