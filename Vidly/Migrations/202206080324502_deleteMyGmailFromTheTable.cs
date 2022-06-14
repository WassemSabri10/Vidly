namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteMyGmailFromTheTable : DbMigration
    {
        public override void Up()
        {

            Sql("Delete from [dbo].[AspNetUsers] where [ID] = (N'340c4017-3f09-444a-b4fa-f1e7471c6859')"); 

        }

        public override void Down()
        {
        }
    }
}
