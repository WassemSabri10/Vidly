namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn : DbMigration
    {
        public override void Up()
        {
            Sql("alter table [dbo].[MembershipTypes] add  TypeOfMemberShip nvarchar(255)");
        }
        
        public override void Down()
        {
        }
    }
}
