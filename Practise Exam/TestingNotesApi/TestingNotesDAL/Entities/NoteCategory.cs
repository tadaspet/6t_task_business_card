using KeepNotesDAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingNotesDAL.Entities
{
    public class NoteCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public List<Note>? Notes { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
