using System.ComponentModel.DataAnnotations;

namespace RegisterPersonAPI.Dtos.Requests
{
    public class SettlementRequestDto
    {
        [Required]
        [StringLength(30, ErrorMessage = "City can't be longer than 30 characters")]
        public string City { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Street can't be longer than 50 characters")]
        public string Street { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "Building Number can't be longer than 5 characters")]
        public string BuildingNo { get; set; }
        [Required]
        [StringLength(6, ErrorMessage = "Flat Number can't be longer than 6 characters")]
        public string? FlatNo { get; set; }
    }
}
