namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCustomerTable : DbMigration
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
