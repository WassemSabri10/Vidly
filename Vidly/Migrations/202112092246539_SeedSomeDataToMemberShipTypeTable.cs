namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSomeDataToMemberShipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into [dbo].[MembershipTypes] (Id,SignUpFee,DurationInMonths,DiscountRate) values (1,0,0,0)");
            Sql("Insert into [dbo].[MembershipTypes] (Id,SignUpFee,DurationInMonths,DiscountRate) values (2,30,1,10)");
        }
        
        public override void Down()
        {
        }
    }
}
