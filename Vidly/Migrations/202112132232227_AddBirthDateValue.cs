namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateValue : DbMigration
    {
        public override void Up()
        {
            Sql("update [dbo].[Customers] set [BirthDate] = '12/1/2021' where Id = 1");
            Sql("update [dbo].[Customers] set [BirthDate] = '12/1/2022' where Id = 2");
        }
        
        public override void Down()
        {
            
        }
    }
}
