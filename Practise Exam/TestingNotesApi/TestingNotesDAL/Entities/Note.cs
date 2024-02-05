using KeepNotesDAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingNotesDAL.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set;}
        public List<ImageFile>? Images { get; set; }
        public int NoteCategoryId { get; set; }
        [ForeignKey("NoteCategoryId")]
        public NoteCategory NoteCategory { get; set; }
    }
}
