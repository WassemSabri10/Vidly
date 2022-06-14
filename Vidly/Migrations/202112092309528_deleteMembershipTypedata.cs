namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteMembershipTypedata : DbMigration
    {
        public override void Up()
        {
            Sql("select * from [dbo].[Customers]");
            
        }
        
        public override void Down()
        {
        }
    }
}
