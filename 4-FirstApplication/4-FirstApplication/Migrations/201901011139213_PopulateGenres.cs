namespace _4_FirstApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'Action')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'Adult')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
