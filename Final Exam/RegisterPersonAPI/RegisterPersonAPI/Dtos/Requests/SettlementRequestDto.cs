using System.ComponentModel.DataAnnotations;

namespace RegisterPersonAPI.Dtos.Requests
{
    public class SettlementRequestDto
    {
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "City can't be longer than 40 characters and shorter than 2 characters.")]
        public string City { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Street can't be longer than 40 characters and shorter than 2 characters.")]
        public string Street { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Building Number can't be longer than 5 characters and shorter than 1 characters.")]
        public string BuildingNo { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Flat Number can't be longer than 6 characters and shorter than 1 characters.")]
        public string? FlatNo { get; set; }
    }
}
