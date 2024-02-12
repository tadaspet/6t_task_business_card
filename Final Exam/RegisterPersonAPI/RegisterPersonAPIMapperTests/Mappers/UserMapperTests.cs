using Xunit;
using RegisterPersonAPI.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegisterPersonAPI.DTOs.Requests;
using RegisterPersonApi.BLL.Services.Interfaces;
using Moq;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using RegisterPersonApi.BLL.Services;


namespace RegisterPersonAPI.Mappers.Tests
{
    public class UserMapperTests
    {
        private readonly Mock<IUsersService> _userService;

        public UserMapperTests()
        {
            _userService = new Mock<IUsersService>();
        }

        [Fact]
        public void Map_WhenUserCreateRequestDTO_ReturnUser()
        {
            //Arrange
            var dto = new UserCreateRequestDTO
            {
                UserName = "TestUserName",
                Email = "TestEmail",
                Password = "TestPassword",

            };

            var passwordHash = new byte[] { 1, 2, 3 };
            var passwordSalt = new byte[] { 4, 5, 6 };

            _userService.Setup(s => s.CreatePasswordHash(dto.Password, out passwordHash, out passwordSalt));

            var mapper = new UserMapper(_userService.Object);

            // Act
            var user = mapper.Map(dto);

            // Assert
            Assert.Equal(dto.UserName, user.Username);
            Assert.Equal(dto.Email, user.Email);
            Assert.Equal(passwordHash, user.Password);
            Assert.Equal(passwordSalt, user.PasswordSalt);
            Assert.Equal("User", user.Role);

        }
    }
}