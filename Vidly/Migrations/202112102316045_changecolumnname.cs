namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changecolumnname : DbMigration
    {
        public override void Up()
        {
            
            Sql("alter table [dbo].[MembershipTypes] drop column [MembershipType]");
        }
        
        public override void Down()
        {
        }
    }
}
