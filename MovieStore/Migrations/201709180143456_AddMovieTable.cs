namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);

            Sql("INSERT INTO Movies (Name, ReleaseDate,  DateAdded, NumberInStock, GenreId) VALUES ('Hangover', CAST('2017-05-25' AS DATETIME), CAST('2015-06-18' AS DATETIME), 50, 1 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate,  DateAdded, NumberInStock, GenreId) VALUES ('Die Hard', CAST('2017-06-18' AS DATETIME), CAST('2016-01-20' AS DATETIME), 20, 2 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate,  DateAdded, NumberInStock, GenreId) VALUES ('The Terminator', CAST('2017-09-20' AS DATETIME), CAST('2016-02-10' AS DATETIME), 30, 2 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate,  DateAdded, NumberInStock, GenreId) VALUES ('Toy Story', CAST('2017-08-20' AS DATETIME), CAST('2016-03-15' AS DATETIME), 25, 3 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate,  DateAdded, NumberInStock, GenreId) VALUES ('Titanic', CAST('2017-10-15' AS DATETIME), CAST('2016-01-13' AS DATETIME), 85, 4 )");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropTable("dbo.Movies");
        }
    }
}
