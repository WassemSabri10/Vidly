namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertdatatoGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id,Name) values (1,'Animation')");
            Sql("Insert into Genres (Id,Name) values (2,'Comedy')");
            Sql("Insert into Genres (Id,Name) values (3,'Drama')");
            Sql("Insert into Genres (Id,Name) values (4,'Family')");
            Sql("Insert into Genres (Id,Name) values (5,'Horror')");
            Sql("Insert into Genres (Id,Name) values (6,'Romance')");
            Sql("Insert into Genres (Id,Name) values (7,'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
