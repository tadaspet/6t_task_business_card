namespace _2._2012.IntroductionAPI.DataLayer.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
