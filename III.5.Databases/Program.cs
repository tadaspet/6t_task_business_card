using Microsoft.EntityFrameworkCore;

namespace III._5.Databases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new BookContext();

            // INSERT:
            //var page = new Page(1, "Puslapio turinys");
            //dbContext.Pages.Add(page);
            //dbContext.SaveChanges();

            // DELETE:

            //var pageDel = new Page(new Guid("CA1CF004-7D56-47AE-969F-F40E96051E4A"));
            //dbContext.Pages.Remove(pageDel);
            //dbContext.SaveChanges();

            // SELECT:
            //var page = dbContext.Pages.Where(p=>p.Number > 1).ToList();

            // UPDATE
            //var page = dbContext.Pages.First(p=>p.Id == Guid.Parse("DE186D31-076F-4594-879F-7E01C8ACD362"));
            //page.Content += ". Added new content";
            //dbContext.SaveChanges();


            // ADD BOOK with child pages
            //var book = new Book("Harry Poter");
            //for (int i = 0; i < 565; i++)
            //{
            //    book.Pages.Add(new Page(i, $"content - {i}"));
            //}

            //dbContext.Books.Add(book);
            //dbContext.SaveChanges();

            // DELETE book with pages.
            //var book = dbContext.Books.Include(b => b.Pages).FirstOrDefault(b => b.Id == new Guid("24B4103D-C90D-4DBD-B71F-6383EC150A28"));
            //dbContext.Books.Remove(book);
            //dbContext.SaveChanges();

        }
    }
}