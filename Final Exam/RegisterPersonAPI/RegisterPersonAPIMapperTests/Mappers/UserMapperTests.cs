using Moq;
using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonAPI.DTOs.Requests;
using Xunit;


namespace RegisterPersonAPI.Mappers.Tests
{
    public class UserMapperTests
    {
        private readonly Mock<IUsersService> _userService;
        private readonly UserMapper _sut;
        public UserMapperTests()
        {
            _userService = new Mock<IUsersService>();
            _sut = new UserMapper(_userService.Object);
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

            // Act
            var user = _sut.Map(dto);

            // Assert
            Assert.Equal(dto.UserName, user.Username);
            Assert.Equal(dto.Email, user.Email);
            Assert.Equal(passwordHash, user.Password);
            Assert.Equal(passwordSalt, user.PasswordSalt);
            Assert.Equal("User", user.Role);

        }
    }
}