using TestingNotesDAL.Entities;

namespace KeepNotesDAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<NoteCategory> NoteCategories { get; set; }
    }
}
