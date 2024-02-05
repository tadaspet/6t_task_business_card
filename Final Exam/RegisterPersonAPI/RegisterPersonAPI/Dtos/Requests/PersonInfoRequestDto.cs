using System.ComponentModel.DataAnnotations;

namespace RegisterPersonAPI.Dtos.Requests
{
    public class PersonInfoRequestDto
    {
        [Required]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Surname can't be longer than 50 characters")]
        public string Surname { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "IdentityCode can't be longer than 20 characters")]
        public string IdentityCode { get; set; }
        [Required]
        [Phone(ErrorMessage = "PhoneNo is not a valid phone number")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email is not a valid email address")]
        public string Email { get; set; }
    }
}
