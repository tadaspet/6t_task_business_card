using III._6.DataBases._8.lesson.DataBase;
using III._6.DataBases._8.lesson.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace III._6.DataBases._8.lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, Many to Many!");

            //var dbContext = new BookContext(new DbContextOptionsBuilder<BookContext>()
            //    .UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=BookCategories;Trusted_Connection=True;")
            //    .Options);
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();


            //var tolkien = new Author { LastName = "Tolkien" };
            //var adams = new Author { LastName = "Adams" };
            //var herbert = new Author { LastName = "Herbert" };
            //var card = new Author { LastName = "Card" };

            //dbContext.Authors.AddRange(tolkien, adams, herbert, card);
            //dbContext.SaveChanges();

            //var hobbit = new Book { Title = "The Hobbit", Year = 1937, Author = tolkien };
            //var lordOfRings = new Book { Title = "Lor Of Rings", Year = 1954, Author = tolkien };
            //var silmarilion = new Book { Title = "The Silmarilion", Year = 1977, Author = tolkien };
            //var hitchHikerGuide = new Book { Title = "The Hitch Hikers Guide to the Galaxy", Year = 1979, Author = adams };
            //var dune = new Book { Title = "Dune", Year = 1965, Author = herbert };
            //var endersGame = new Book { Title = "Ender's Game", Year = 1985, Author = card };

            //dbContext.Books.AddRange(hobbit, lordOfRings, silmarilion, hitchHikerGuide, dune, endersGame);
            //dbContext.SaveChanges();

            //var catAdventure = new Category { CategoryName = "Adventure" };
            //var catScience = new Category { CategoryName = "Science Fiction" };

            //dbContext.Categories.AddRange(catAdventure, catScience);
            //dbContext.SaveChanges();

            //dbContext.BookCategories.Add(new BookCategory { Category = catAdventure, Book = hobbit });
            //dbContext.BookCategories.Add(new BookCategory { Category = catAdventure, Book = lordOfRings });
            //dbContext.BookCategories.Add(new BookCategory { Category = catAdventure, Book = silmarilion });
            //dbContext.BookCategories.Add(new BookCategory { Category = catScience, Book = hitchHikerGuide });
            //dbContext.BookCategories.Add(new BookCategory { Category = catScience, Book = dune });
            //dbContext.BookCategories.Add(new BookCategory { Category = catScience, Book = endersGame });

            //dbContext.SaveChanges();

            //using var dbContext = new BookContext();

            //var booksSelect = dbContext.Books
            //    .Include(b => b.Author)
            //    .Include(b=>b.BookCategories)
            //    .ThenInclude(c=>c.Category)
            //    .Where(b => b.Year < 1975);

            //foreach (var book in booksSelect)
            //{
            //    Console.WriteLine(book.Title);

            //    foreach(var category in book.BookCategories)
            //    {
            //        Console.WriteLine(category.Category.CategoryName);
            //    }
            //    Console.WriteLine(book.Author.LastName+"\n");
            //}

        }
    }
}