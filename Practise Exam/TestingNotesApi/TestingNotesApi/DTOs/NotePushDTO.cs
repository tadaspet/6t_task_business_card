using KeepNotesDAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace TestingNotesApi.DTOs
{
    public class NotePushDTO
    {
        public int NoteCategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
