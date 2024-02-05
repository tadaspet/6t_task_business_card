using System.ComponentModel.DataAnnotations;

namespace TestingNotesApi.DTOs
{
    public class NoteUpdateDTO
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Title { get; set; }
        [Required]
        [StringLength(20000, MinimumLength = 1)]
        public string Content { get; set; }
    }
}
