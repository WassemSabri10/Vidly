namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertIntoNameMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update [dbo].[MembershipTypes] set [Name] = 'Sally' where Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
