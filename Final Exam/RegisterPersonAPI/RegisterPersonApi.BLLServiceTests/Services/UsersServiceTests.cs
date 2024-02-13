using Moq;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using Xunit;

namespace RegisterPersonApi.BLL.Services.Tests
{
    public class UsersServiceTests
    {
        private readonly Mock<IUsersRepository> _userRespo;
        private readonly UsersService _sut;

        public UsersServiceTests()
        {
            _userRespo = new Mock<IUsersRepository>();
            _sut = new UsersService(_userRespo.Object);
        }

        [Fact]
        public void Login_WhenValidUser_ReturnUser()
        {
            // Arrange
            var username = "TestUser";
            var expectedUser = new User { Username = username };

            _userRespo.Setup(repo => repo.GetUser(username)).Returns(expectedUser);

            // Act
            var actualUser = _sut.UserExists(username);

            // Assert
            Assert.Equal(expectedUser, actualUser);
        }

        [Fact]
        public void Login_WhenUserDoesNotExists_ReturnNull()
        {
            // Arrange
            var username = "TestUser";
            var expectedUser = new User { Username = username };

            _userRespo.Setup(repo => repo.GetUser(username)).Returns(expectedUser);

            // Act
            var actualUser = _sut.UserExists("UserDoesNotExits");

            // Assert
            Assert.NotEqual(expectedUser, actualUser);
        }

        [Fact]
        public void SingUp_WhenUserExists_ReturnsEmptyGuid()
        {
            // Arrange
            var existingUser = new User { Username = "TestUser" };

            _userRespo.Setup(repo => repo.GetUser(existingUser.Username)).Returns(existingUser);

            //Act
            var result = _sut.UserSignUp(existingUser);

            //Assert
            Assert.Equal(Guid.Empty, result);
        }

        [Fact]
        public void SingUp_WhenUserDoesNotExist_ReturnsSavedUserGuid()
        {
            // Arrange
            var newUser = new User { Username = "NewTestUser" };
            var newUserId = Guid.NewGuid();

            _userRespo.Setup(repo => repo.GetUser(newUser.Username)).Returns((User)null);
            _userRespo.Setup(repo => repo.SaveUser(newUser)).Returns(newUserId);

            //Act
            var result = _sut.UserSignUp(newUser);

            //Assert
            Assert.Equal(newUserId, result);

        }

        [Fact]
        public void WhenDeleteUserAndInformation_DeletesUser_ReturnsTrue()
        {
            // Arrange
            var userId = Guid.NewGuid();

            _userRespo.Setup(x => x.DeleteUserAndAllInformation(userId)).Returns(true);

            // Act
            var result = _sut.DeleteUserAndInformation(userId);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void WhenDeleteUserAndInformation_DoNotDeleteUser_ReturnsFalse()
        {
            // Arrange
            var userId = Guid.NewGuid();

            _userRespo.Setup(x => x.DeleteUserAndAllInformation(userId)).Returns(false);

            // Act
            var result = _sut.DeleteUserAndInformation(userId);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void VerifyPasswordHash_ReturnsTrue_WhenPasswordMatchesHashAndSalt()
        {
            // Arrange
            var password = "testPassword";
            byte[] passwordHash;
            byte[] passwordSalt;

            _sut.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            // Act
            var result = _sut.VerifyPasswordHash(password, passwordHash, passwordSalt);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyPasswordHash_ReturnsFalse_WhenPasswordDoesNotMatchHashAndSalt()
        {
            // Arrange
            var password = "testPassword";
            var wrongPassword = "wrongPassword";
            byte[] passwordHash;
            byte[] passwordSalt;

            _sut.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            // Act
            var result = _sut.VerifyPasswordHash(wrongPassword, passwordHash, passwordSalt);

            // Assert
            Assert.False(result);
        }

    }
}