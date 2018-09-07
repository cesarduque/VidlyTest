namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Hangover',25/09/1989,25/09/1989,5, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Die Hard',25/09/1989,25/09/1989,5, 1)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('The Terminator',25/09/1989,25/09/1989,5, 1)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Toy Story',25/09/1989,25/09/1989,5, 3)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES ('Titanic',25/09/1989,25/09/1989,5,4 )");
        }
        
        public override void Down()
        {
        }
    }
}
