using Moq;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using Xunit;

namespace RegisterPersonApi.BLL.Services.Tests
{
    public class PersonInformationServiceTests
    {
        private readonly Mock<IPersonInformationRepository> _repo;
        private readonly PersonInformationService _sut;

        public PersonInformationServiceTests()
        {
            _repo = new Mock<IPersonInformationRepository>();
            _sut = new PersonInformationService(_repo.Object);
        }

        [Fact]
        public void WhenGetPersonalInformation_ReceivesGuid_ReturnsPersonInformation()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var fakePersonInfo = new PersonInformation
            {
                Name = "TestName",
                Surname = "TestNameSurname",
                IdentityCode = "TestIdentityCode",
                PhoneNo = "TestPhoneNo",
                Email = "TestEmail",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14),
            };

            _repo.Setup(x => x.GetPersonalInformation(userId)).Returns(fakePersonInfo);

            // Act
            var result = _sut.GetPersonalInformation(userId);

            // Assert
            Assert.Equal(fakePersonInfo, result);
        }

        [Fact]
        public void WhenGetPersonalInformation_ReceivesGuid_ReturnsNullPersonInformation()
        {
            // Arrange
            var userId = Guid.NewGuid();

            _repo.Setup(x => x.GetPersonalInformation(userId)).Returns((PersonInformation)null);

            // Act
            var result = _sut.GetPersonalInformation(userId);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void WhenAddNewPersonInformation_ReceivesPersonInformation_ReturnsIntZeroValue()
        {
            // Arrange
            var expected = 0;
            var fakePersonInfo = new PersonInformation
            {
                Name = "TestName",
                Surname = "TestNameSurname",
                IdentityCode = "TestIdentityCode",
                PhoneNo = "TestPhoneNo",
                Email = "TestEmail",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14),
                UserId = Guid.NewGuid(),
            };

            _repo.Setup(x => x.GetPersonalInformation(fakePersonInfo.UserId)).Returns(fakePersonInfo);

            //Act
            var result = _sut.AddNewPersonInformation(fakePersonInfo);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenAddNewPersonInformation_ReceivesPersonInformation_ReturnsIntNotZeroValue()
        {
            // Arrange
            var expected = 1;
            var fakePersonInfo = new PersonInformation
            {
                Name = "TestName",
                Surname = "TestNameSurname",
                IdentityCode = "TestIdentityCode",
                PhoneNo = "TestPhoneNo",
                Email = "TestEmail",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14),
                UserId = Guid.NewGuid(),
            };

            _repo.Setup(x => x.GetPersonalInformation(fakePersonInfo.UserId)).Returns((PersonInformation)null);
            _repo.Setup(x => x.AddNewPersonInformation(fakePersonInfo)).Returns(expected);
            //Act
            var result = _sut.AddNewPersonInformation(fakePersonInfo);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenUpdatePersonInformation_ReceivesPersonInformation_ReturnsTrue()
        {
            // Arrange
            var expected = true;
            var fakePersonInfo = new PersonInformation
            {
                Name = "TestName",
                Surname = "TestNameSurname",
                IdentityCode = "TestIdentityCode",
                PhoneNo = "TestPhoneNo",
                Email = "TestEmail",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14),
                UserId = Guid.NewGuid(),
            };

            _repo.Setup(x => x.GetPersonalInformation(fakePersonInfo.UserId)).Returns(fakePersonInfo);
            _repo.Setup(x => x.UpdatePersonInformation(fakePersonInfo)).Returns(expected);
            //Act
            var result = _sut.UpdatePersonInformation(fakePersonInfo);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenUpdatePersonInformation_ReceivesPersonInformation_ReturnsFalse()
        {
            // Arrange
            var expected = false;
            var fakePersonInfo = new PersonInformation
            {
                Name = "TestName",
                Surname = "TestNameSurname",
                IdentityCode = "TestIdentityCode",
                PhoneNo = "TestPhoneNo",
                Email = "TestEmail",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14),
                UserId = Guid.NewGuid(),
            };

            _repo.Setup(x => x.GetPersonalInformation(fakePersonInfo.UserId)).Returns((PersonInformation)null);
            _repo.Setup(x => x.UpdatePersonInformation(fakePersonInfo)).Returns(expected);
            //Act
            var result = _sut.UpdatePersonInformation(fakePersonInfo);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}