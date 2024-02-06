using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using System.Security.Cryptography;

namespace RegisterPersonApi.BLL.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public User Login(string username, string password)
        {
            var user = _usersRepository.GetUser(username);
            if (user is null)
            {
                return null;
            }
            return user;
        }

        public Guid Signup(User requestUser)
        {
            var user = _usersRepository.GetUser(requestUser.Username);
            if (user != null)
            {
                return Guid.Empty;
            }
            var userId = _usersRepository.SaveUser(requestUser);
            return userId;
        }

        public bool DeleteUserAndInformation(Guid userId)
        {
            return _usersRepository.DeleteUserAndAllInformation(userId);
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        }
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
