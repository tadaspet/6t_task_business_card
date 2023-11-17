using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III._6.DataBases._8.lesson.DataBase.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string LastName { get; set; }
        public virtual List<Book> Books { get; set; }  //kompozicija i lentele
    }
}
