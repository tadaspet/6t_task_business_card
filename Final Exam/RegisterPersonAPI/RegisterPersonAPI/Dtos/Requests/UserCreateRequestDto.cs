using System.ComponentModel.DataAnnotations;

namespace RegisterPersonAPI.DTOs.Requests
{
    public class UserCreateRequestDTO
    {
        /// <summary>
        /// User name 
        /// </summary>
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]{6,20}$", ErrorMessage = "Invalid username. Username must be case sensitive, " +
            "contain only letters and numbers, and be between 6 and 20 characters.")]
        public string UserName { get; set; }
        /// <summary>
        /// User Email address
        /// </summary>
        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])[A-Za-z0-9]+@[A-Za-z0-9]+\.[A-Za-z]{2,}$", ErrorMessage = "Email is not a valid email address")]
        public string Email { get; set; }
        /// <summary>
        /// User password
        /// </summary>
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,20}$",
            ErrorMessage = "Invalid password. Password must contain at least one uppercase letter, one lowercase letter, " +
            "one digit, and be between 8 and 20 characters.")]
        public string Password { get; set; }
    }
}
