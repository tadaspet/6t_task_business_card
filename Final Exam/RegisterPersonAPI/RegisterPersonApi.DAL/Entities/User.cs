﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterPersonApi.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? PreviousLogin { get; set; }
        public PersonInformation PersonInformation { get; set; }
    }
}
