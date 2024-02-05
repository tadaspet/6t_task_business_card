using System.ComponentModel.DataAnnotations;

namespace TestingNotesApi.DTOs
{
    public class NoteGetDTO
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Title { get; set; }
        [Required]
        [StringLength(20000, MinimumLength = 1)]
        public string Content { get; set; }
        [Required]
        [Range(1, 2147483647)]
        public int NoteCategoryId { get; set; }
    }
}
