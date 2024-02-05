using System.ComponentModel.DataAnnotations;
using TestingNotesDAL.Entities;

namespace TestingNotesApi.DTOs
{
    public class NoteCategoryPushDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public List<Note>? Notes { get; set; }
    }
}
