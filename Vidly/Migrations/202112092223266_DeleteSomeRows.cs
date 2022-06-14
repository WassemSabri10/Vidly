namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSomeRows : DbMigration
    {
        public override void Up()
        {
            Sql("delete from [dbo].[MembershipTypes] where id =1");
            Sql("delete from [dbo].[MembershipTypes] where id =2");
            Sql("delete from [dbo].[MembershipTypes] where id =3");
        }
        
        public override void Down()
        {
        }
    }
}
