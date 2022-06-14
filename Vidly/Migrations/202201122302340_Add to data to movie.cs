namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtodatatomovie : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) values ('Rocky','2015-07-10','2015-07-12',20,1)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) values ('Terminator','2015-08-10','2015-07-12',18,2)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) values ('Sonic','2015-06-10','2015-07-10',17,3)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) values ('Alvin','2015-05-10','2015-07-11',16,4)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) values ('HomeAlone','2015-07-10','2015-09-10',15,5)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) values ('America','2015-04-10','2015-07-20',14,6)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,GenreId) values ('Rambo','2015-06-10','2015-07-01',12,7)");
        }
        
        public override void Down()
        {
        }
    }
}
