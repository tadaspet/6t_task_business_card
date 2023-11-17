namespace III._6.DataBases._8.lesson.DataBase.Models
{
    public class BookCategory   //Many-to-Many jungiamoji lentele
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public virtual Book Book { get; set; }  
        public virtual Category Category { get; set;}
    }
}
