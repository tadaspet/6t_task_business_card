using System.ComponentModel.DataAnnotations;

namespace RegisterPersonAPI.Dtos.Requests
{
    public class PersonInfoRequestDto
    {
        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Name can't be longer than 30 characters and shorter than 1 character.")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Surname can't be longer than 50 characters and shorter than 1 character.")]
        public string Surname { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "IdentityCode can't be longer than 20 characters and shorter than 10 characters.")]
        public string IdentityCode { get; set; }
        [Required]
        [Phone(ErrorMessage = "Phone number can include digits, spaces, parentheses, hyphens, periods and plus sign.")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email is not a valid email address")]
        public string Email { get; set; }
    }
}
