using System.ComponentModel.DataAnnotations;

namespace III._6.DataBases._8.lesson.DataBase.Models
{
    public class Category 
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual List<BookCategory> BookCategories { get; set; }   //todo kompozicija i book

    }
}
