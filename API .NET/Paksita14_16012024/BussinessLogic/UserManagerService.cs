using Microsoft.AspNetCore.Identity;
using Paksita14_16012024.DataLayer;
using Paksita14_16012024.Models;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace Paksita14_16012024.BussinessLogic
{
    public interface IUserManagerService
    {
        User? CreateAccount(string userName, string password, string email, string role);
        void CreatePasswordHash(string password,out byte[] passwordHash, out byte[] passwordSalt);
        bool TryVerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt);
        public bool TryLogin(string userName, string password, out string role, out int? userId);
        int GetCurrentUserId();
    }
    public class UserManagerService : IUserManagerService
    {
        private readonly ShoppingListDbContex _context;
        private readonly ILogger<UserManagerService> _logger;
        private readonly IHttpContextAccessor _contextAccessor;

        public UserManagerService(ShoppingListDbContex context, ILogger<UserManagerService> logger, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _logger = logger;
            _contextAccessor = contextAccessor;
        }
        public User? CreateAccount(string userName, string password, string email, string role)
        {

            CreatePasswordHash(password, out var passwordHash, out var passwordSalt);
            var found = _context.Users.Any(u => u.UserName == userName);
            if (found)
            {
                _logger.LogError("User already exists");
                return null;
            }
            var user = new User
            {
                UserName = userName,
                Email = email,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                Role = role
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public int GetCurrentUserId()
        {
            var userId = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return int.Parse(userId);
        }

        public bool TryLogin(string userName, string password, out string role, out int? userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == userName);
            if (user == null)
            {
                _logger.LogWarning($"User {user.UserName} does not exists");
                role = "";
                userId = null;
                return false;
            }
            role = user.Role;
            userId = user.Id;
            var verified = TryVerifyPasswordHash(password, user.Password, user.PasswordSalt);
            if(!verified)
            {
                _logger.LogWarning($"User {user.UserName} password does not match");
            }
            return verified;
        }

        public bool TryVerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var hmac = new HMACSHA512(storedSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(storedHash);
        }
    }
}
