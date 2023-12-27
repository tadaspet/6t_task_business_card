using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _2._2012.IntroductionAPI.DataBase;
using static System.Runtime.InteropServices.JavaScript.JSType;
using _2._2012.IntroductionAPI.DataLayer.Models;

namespace _2._2012.IntroductionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("list10")]
        [HttpGet] //api/Book/{list}
        public IEnumerable<Book> GetAll()
        {
            var database = new BookInMemory();
            var data = database.GetAll().Where(b => b.Id < 11);
            return data;
        }

        [HttpGet("{id}")] //api/Book/{id}
        public Book GetOneById(int id)
        {
            var database = new BookInMemory();
            var data = database.GetAll().Find(b => b.Id == id);
            return data;
        }

        [HttpGet("{pageNum}/{pageSize}")] //api/Book/{pageNum}/{pageSize}
        public IEnumerable<Book> GetPageOfBooks(int pageNum, int pageSize)
        {
            var database = new BookInMemory();
            IEnumerable<Book> data;
            if (pageNum <= 0)
            {
                data = null;
            }
            else
            {
                data = database.GetAll().Skip((pageNum - 1) * pageSize).Take(pageSize);
            }
            return data;
            //return database.GetAll().Skip((pageNum - 1) * pageSize).Take(pageSize);
        }

        [HttpGet("sortedList")] //api/Book/sortedList
        public IEnumerable<Book> GetPageOfBooks()
        {
            var database = new BookInMemory();
            var pageSize = 10;
            var data = database.GetAll().OrderBy(b => b.Title);
            return data;
        }

        [HttpGet("filterByTitleOrAuthor/{para}")] //api/Book/sortedList
        public IEnumerable<Book> GetBooksByAuthorOrTitle(string para)
        {
            var database = new BookInMemory();
            var data = database.GetAll().Where(b => b.Title.StartsWith(para, StringComparison.OrdinalIgnoreCase));
            if (data.Count() < 1)
            {
                data = database.GetAll().Where(b => b.Author.StartsWith(para, StringComparison.OrdinalIgnoreCase));
            }
            return data;
        }
        [HttpPost]
        public void CreateBook(Book book)
        {
            var database = new BookInMemory();
            database.InsertBook(book);
        }

        [HttpPut]
        public void UpdateBook(Book book)
        {
            var database = new BookInMemory();
            database.UpdateBook(book);
        }
        [HttpDelete("{id}")]
        public void DeleteBook(int id)
        {
            var database = new BookInMemory();
            database.DeleteBook(id);
        }
    }
}
