﻿namespace Paksita14_16012024.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName {  get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public List<ShoppingList> ShoppingLists { get; set; }
    }
}
