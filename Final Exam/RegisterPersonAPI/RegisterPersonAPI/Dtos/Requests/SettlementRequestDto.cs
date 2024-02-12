using System.ComponentModel.DataAnnotations;

namespace RegisterPersonAPI.DTOs.Requests
{
    public class SettlementRequestDto
    {
        [Required]
        [RegularExpression("^[a-zA-Z]{2,40}$", ErrorMessage = "City must be between 2 an 40 characters long, and consist only from letters.")]
        public string City { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Street can't be longer than 40 characters and shorter than 2 characters.")]
        public string Street { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Building number can't be longer than 5 characters and shorter than 1 character.")]
        public string BuildingNo { get; set; }
        [StringLength(6, MinimumLength = 0, ErrorMessage = "Flat number can be empty or maximum 6 characters.")]
        public string? FlatNo { get; set; }
    }
}
