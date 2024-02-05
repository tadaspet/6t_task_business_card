using System.ComponentModel.DataAnnotations.Schema;
using TestingNotesDAL.Entities;

namespace KeepNotesDAL.Entities
{
    public class ImageFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public byte[] Content { get; set; }
        public int NoteId { get; set; }
        [ForeignKey("NoteId")]
        public Note Note { get; set; }
    }
}
