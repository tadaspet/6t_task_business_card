using NoteKeeper.Api.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NoteKeeper.Api.DAL.Repositories
{
    public class UsersRepository
    {
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ResponseDto Login(string username, string password, out string role)
        {
            var user = _userRepository.GetUser(username);
            role = user.Role;
            if (user is null)
                return new ResponseDto("Fail", "Username does not match");

            if (!VerifyPasswordHash(password, user.Password, user.PasswordSalt))
                return new ResponseDto("Fail", "Password does not match");

            return new ResponseDto("Success", "User logged in");
        }

        public ResponseDto Signup(string username, string password)
        {
            var user = _userRepository.GetUser(username);
            if (user is not null)
                return new ResponseDto("Fail", "User already exists");

            user = CreateUser(username, password);
            _userRepository.SaveUser(user);
            return new ResponseDto("Success", "User created");
        }

        private User CreateUser(string username, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = username,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                Role = "User"
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
