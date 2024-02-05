using KeepNotesDAL.Entities;
using KeepNotesDAL.Interfacees;
using System.Security.Cryptography;
using TestingNotesApiBLL.Interfaces;


namespace KeepNotesApiBLL.Services
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
            if (!VerifyPasswordHash(password, user.Password, user.PasswordSalt))
            {
                return null;
            }
            return user;
        }

        public int Signup(string username, string password, string email)
        {
            var user = _usersRepository.GetUser(username);
            if (user is not null)
            {
                return 0;
            }
            user = CreateUser(username, password, email);
            var userId = _usersRepository.SaveUser(user);
            return userId;
        }

        private User CreateUser(string username, string password, string email)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            var user = new User
            {
                Username = username,
                Email = email,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
            };
            return user;
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
