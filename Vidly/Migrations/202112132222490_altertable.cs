namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertable : DbMigration
    {
        public override void Up()
        {
            Sql("alter table [dbo].[Customers] alter column [BirthDate] datetime null");
        }
        
        public override void Down()
        {
        }
    }
}
