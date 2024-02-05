using KeepNotesDAL.Entities;

namespace KeepNotesDAL.Interfacees
{
    public interface IUsersRepository
    {
        public User GetUser(string userName);
        int SaveUser(User user);
    }
}