using III._6.DataBases._8.lesson.DataBase;
using III._6.DataBases._8.lesson.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace TestingManyToMany
{
    [TestClass]
    public class BookContextTest
    {
        private BookContext dbContext;
        [TestInitialize]
        //public void OnInit()
        //{
        //    dbContext = new BookContext(new DbContextOptionsBuilder<BookContext>()
        //        .UseInMemoryDatabase(databaseName: "BookContext" + Guid.NewGuid())
        //        .UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=BookCategories;Trusted_Connection=True;")
        //        .Options);
        //    dbContext.Database.EnsureDeleted();
        //    dbContext.Database.EnsureCreated();
        //}
        [TestMethod]
        public void TestMethod1()
        {
            var tolkien = new Author { LastName = "Tolkien" };
            var adams = new Author { LastName = "Adams" };
            var herbert = new Author { LastName = "Herbert" };
            var card = new Author { LastName = "Card" };

            dbContext.Authors.AddRange(tolkien, adams, herbert, card);
            dbContext.SaveChanges();

            var hobbit = new Book { Title = "The Hobbit", Year = 1937, Author = tolkien };
            var lordOfRings = new Book { Title = "Lor Of Rings", Year = 1954, Author = tolkien };
            var silmarilion = new Book { Title = "The Silmarilion", Year = 1977, Author = tolkien };
            var hitchHikerGuide = new Book { Title = "The Hitch Hikers Guide to the Galaxy", Year = 1979, Author = adams };
            var dune = new Book { Title = "Dune", Year = 1965, Author = herbert };
            var endersGame = new Book { Title = "Ender's Game", Year = 1985, Author = card };

            dbContext.Books.AddRange(hobbit, lordOfRings, silmarilion, hitchHikerGuide, dune, endersGame);
            dbContext.SaveChanges();

            var catAdventure = new Category { CategoryName = "Adventure" };
            var catScience = new Category { CategoryName = "Science Fiction" };

            dbContext.Categories.AddRange(catAdventure, catScience);
            dbContext.SaveChanges();

            dbContext.BookCategories.Add(new BookCategory { Category = catAdventure, Book = hobbit });
            dbContext.BookCategories.Add(new BookCategory { Category = catAdventure, Book = lordOfRings });
            dbContext.BookCategories.Add(new BookCategory { Category = catAdventure, Book = silmarilion });

            dbContext.BookCategories.Add(new BookCategory { Category = catScience, Book = hitchHikerGuide });
            dbContext.BookCategories.Add(new BookCategory { Category = catScience, Book = dune });
            dbContext.BookCategories.Add(new BookCategory { Category = catScience, Book = endersGame });
            dbContext.BookCategories.Add(new BookCategory { Category = catScience, Book = hobbit });

            dbContext.SaveChanges();

            Assert.AreEqual(4, dbContext.Authors.Count());
            Assert.AreEqual(6, dbContext.Books.Count());
            Assert.AreEqual(2, dbContext.Categories.Count());
            Assert.AreEqual(7, dbContext.BookCategories.Count());


        }
    }
}