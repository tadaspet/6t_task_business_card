using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;
using RegisterPersonAPI.Mappers.Interfaces;

namespace RegisterPersonAPI.Mappers
{
    public class UserMapper : IUserMapper
    {
        private readonly IUsersService _usersService;

        public UserMapper(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public User Map(UserCreateRequestDTO dto)
        {
            _usersService.CreatePasswordHash(dto.Password, out var passwordHash, out var passwordSalt);
            var model = new User
            {
                Username = dto.UserName,
                Email = dto.Email,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                CreationDate = DateTime.Now,
                Role = "User"
            };
            return model;
        }
    }
}
