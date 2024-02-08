using RegisterPersonApi.DAL.ApiDbContext;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly RegisterDbContext _dbContex;

        public UsersRepository(RegisterDbContext userContext)
        {
            _dbContex = userContext;
        }

        public User GetUser(string userName)
        {
            return _dbContex.Users.FirstOrDefault(u => u.Username == userName);
        }
        public User GetUserByEmail(string email)
        {
            return _dbContex.Users.FirstOrDefault(u => u.Email == email);
        }
        public User GetUserByUsername(string username)
        {
            return _dbContex.Users.FirstOrDefault(u => u.Username == username);
        }
        public User GetUserByGuid(Guid userId)
        {
            var user = _dbContex.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return null;
            }
            return user;
        }
        public Guid SaveUser(User user)
        {
            _dbContex.Users.Add(user);
            _dbContex.SaveChanges();
            return user.Id;
        }
        public void SaveLogin(User user)
        {
            user.PreviousLogin = DateTime.Now;
            _dbContex.Users.Update(user);
            _dbContex.SaveChanges();
        }

        public bool DeleteUserAndAllInformation(Guid userId)
        {
            var user = _dbContex.Users.FirstOrDefault(u => u.Id == userId);
            if(user == null)
            {
                return false;
            }
            var personInformation = _dbContex.PersonInformations.FirstOrDefault(u => u.UserId == userId);

            if(personInformation == null)
            {
                _dbContex.Users.Remove(user);
                _dbContex.SaveChanges();
                return true;
            }

            var imageFile = _dbContex.ImageFiles.FirstOrDefault(i => i.PersonInformationId == personInformation.Id);
            var setlement = _dbContex.Settlements.FirstOrDefault(s => s.PersonInformationId == personInformation.Id);

            if (imageFile != null)
            {
                _dbContex.ImageFiles.Remove(imageFile);                    
            }
            if(setlement != null)
            {
                _dbContex.Settlements.Remove(setlement);
            }
            _dbContex.PersonInformations.Remove(personInformation);
            _dbContex.Users.Remove(user);

            _dbContex.SaveChanges();

            return true;
        }
    }
}
