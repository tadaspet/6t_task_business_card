using KeepNotesDAL.Entities;

namespace TestingNotesApiBLL.Interfaces
{
    public interface IUsersService
    {
        public User Login(string username, string password);
        public int Signup(string username, string password, string email);
    }
}