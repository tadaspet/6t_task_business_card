using KeepNotesDAL.AppDbContext;
using KeepNotesDAL.Entities;
using KeepNotesDAL.Interfacees;

namespace KeepNotesDAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly NotesDbContext _userContext;

        public UsersRepository(NotesDbContext userContext)
        {
            _userContext = userContext;
        }

        public User GetUser(string userName)
        {
            return _userContext.Users.FirstOrDefault(u => u.Username == userName);
        }
        public int SaveUser(User user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
            var newUser = _userContext.Users.FirstOrDefault(u => u.Id == user.Id);
            return newUser.Id;
        }
    }
}
