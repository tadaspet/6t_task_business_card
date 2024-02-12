using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;
using Xunit;

namespace RegisterPersonAPI.Mappers.Tests
{
    public class PersonInfoMapperTests
    {
        [Fact]
        public void Map_WhenPersonInformationDTO_ReturnPersonInformaiton()
        {
            //Arrange
            var fakeGuid = Guid.NewGuid();

            var fakePersonInfoDTO = new PersonInfoRequestDTO
            {
                Name = "TestName",
                Surname = "TestNameSurname",
                IdentityCode = "Test123456789",
                PhoneNo = "TestPhoneNo",
                Email = "TestEmail",
            };

            //Act
            var sut = new PersonInfoMapper();
            var actual = sut.Map(fakePersonInfoDTO, fakeGuid);

            //Assert
            Assert.Equal(fakePersonInfoDTO.Name, actual.Name);
            Assert.Equal(fakePersonInfoDTO.Surname, actual.Surname);
            Assert.Equal(fakePersonInfoDTO.IdentityCode, actual.IdentityCode);
            Assert.Equal(fakePersonInfoDTO.PhoneNo, actual.PhoneNo);
            Assert.Equal(fakePersonInfoDTO.Email, actual.Email);
            Assert.Equal(fakeGuid, actual.UserId);

        }

        [Fact]
        public void Map_WhenPersonInformation_ReturnPersonInfoResultDto()
        {
            //Arrange
            var fakeGuid = Guid.NewGuid();

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

            //Act
            var sut = new PersonInfoMapper();
            var actual = sut.Map(fakePersonInfo);

            //Assert
            Assert.Equal(fakePersonInfo.Name, actual.Name);
            Assert.Equal(fakePersonInfo.Surname, actual.Surname);
            Assert.Equal(fakePersonInfo.IdentityCode, actual.IdentityCode);
            Assert.Equal(fakePersonInfo.PhoneNo, actual.PhoneNo);
            Assert.Equal(fakePersonInfo.CreationDate, actual.CreationDate);
            Assert.Equal(fakePersonInfo.LastModified, actual.LastModified);
        }
    }
}