using System.ComponentModel.DataAnnotations;

namespace III._6.DataBases._8.lesson.DataBase.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public virtual List<BookCategory> BookCategories { get; set; }  //todo kompzicija category
        public virtual Author Author { get; set; }


    }
}
