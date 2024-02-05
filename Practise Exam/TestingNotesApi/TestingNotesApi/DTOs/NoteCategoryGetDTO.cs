using System.ComponentModel.DataAnnotations;

namespace TestingNotesApi.DTOs
{
    public class NoteCategoryGetDTO
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Title { get; set; }
        [StringLength(200, MinimumLength = 5)]
        public string Description { get; set; }
    }
}
