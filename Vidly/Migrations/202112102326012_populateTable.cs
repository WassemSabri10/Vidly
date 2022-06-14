namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateTable : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.MembershipTypes", "TypeOfMemberShip", c => c.String());
            Sql("Update [dbo].[MembershipTypes] set [TypeOfMemberShip] = 'Pay as you go' where id = 1");
            Sql("Update [dbo].[MembershipTypes] set [TypeOfMemberShip] = 'Monthly' where id = 2");
        }
        
        public override void Down()
        {
            //DropColumn("dbo.MembershipTypes", "TypeOfMemberShip");
        }
    }
}
