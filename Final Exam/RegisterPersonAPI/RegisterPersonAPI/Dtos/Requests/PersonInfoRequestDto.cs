using System.ComponentModel.DataAnnotations;

namespace RegisterPersonAPI.Dtos.Requests
{
    public class PersonInfoRequestDto
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]{1,30}$", ErrorMessage = "Name must be between 1-30 characters long and contain only letters.")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s]{1,50}$", ErrorMessage = "Surname must be between 1-50 characters long and contain only letters.")]
        public string Surname { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "IdentityCode can't be longer than 20 characters and shorter than 10 characters.")]
        public string IdentityCode { get; set; }
        [Required]
        [Phone(ErrorMessage = "Phone number can include digits, spaces, parentheses, hyphens, periods and plus sign.")]
        public string PhoneNo { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])[A-Za-z0-9]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$", ErrorMessage = "Email is not a valid.")]
        public string Email { get; set; }
    }
}
