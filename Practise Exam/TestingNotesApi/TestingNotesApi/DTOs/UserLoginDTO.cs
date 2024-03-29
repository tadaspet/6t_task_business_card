﻿using System.ComponentModel.DataAnnotations;

namespace NoteKeeper.Api.DTOs
{
    public class UserLoginDTO
    {
        /// <summary>
        /// User name 
        /// </summary>
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]{6,20}$", ErrorMessage = "Invalid username. Username must be case sensitive, " +
            "contain only letters and numbers, and be between 6 and 20 characters.")]
        public string Username { get; set; } = "Username";
        /// <summary>
        /// User password
        /// </summary>
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,20}$",
            ErrorMessage = "Invalid password. Password must contain at least one uppercase letter, one lowercase letter, " +
            "one digit, one special character, and be between 8 and 20 characters.")]
        public string Password { get; set; } = "Password!1";
    }
}
