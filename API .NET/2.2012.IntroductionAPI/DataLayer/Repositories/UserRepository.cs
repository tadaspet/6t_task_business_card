using _2._2012.IntroductionAPI.DataLayer.FakeDatabase;
using _2._2012.IntroductionAPI.DataLayer.Models;

namespace _2._2012.IntroductionAPI.DataLayer.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string username);
        void SaveUser(User user);
    }

    public class UserRepository : IUserRepository
    {
        private readonly AppBooksDbContext _userRespo;

        public UserRepository(AppBooksDbContext userRespo)
        {
            _userRespo = userRespo;
        }
        public User GetUser(string username)
        {
            return _userRespo.Users.FirstOrDefault(u => u.Username == username);
        }
        public void SaveUser(User user)
        {
            _userRespo.Users.Add(user);
            _userRespo.SaveChanges();
        }
    }
}
