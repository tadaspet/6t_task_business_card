using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;
using Xunit;

namespace RegisterPersonAPI.Mappers.Tests
{
    public class SettlementMapperTests
    {
        [Fact]
        public void Map_WhenSettlementRequestDto_ReturnSettlement()
        {
            //Arrange
            var fakePersonInfoId = 0;
            var fakeSettlementDTO = new SettlementRequestDto
            {
                City = "TestCity",
                Street = "TestStreet",
                BuildingNo = "BuldingNo",
                FlatNo = "TestFlatNo"
            };

            //Act
            var sut = new SettlementMapper();
            var actual = sut.Map(fakeSettlementDTO, fakePersonInfoId);

            //Assert
            Assert.Equal(fakeSettlementDTO.City, actual.City);
            Assert.Equal(fakeSettlementDTO.Street, actual.Street);
            Assert.Equal(fakeSettlementDTO.BuildingNo, actual.BuildingNo);
            Assert.Equal(fakeSettlementDTO.FlatNo, actual.FlatNo);
            Assert.Equal(fakePersonInfoId, actual.PersonInformationId);

        }

        [Fact]
        public void Map_WhenSettlement_ReturnSettlementRequestDto()
        {
            //Arrange
            var fakePersonInfoId = 0;
            var fakeSettlementEntity = new Settlement
            {
                City = "TestCity",
                Street = "TestStreet",
                BuildingNo = "BuldingNo",
                FlatNo = "TestFlatNo",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14)
            };

            //Act
            var sut = new SettlementMapper();
            var actual = sut.Map(fakeSettlementEntity);

            //Assert
            Assert.Equal(fakeSettlementEntity.City, actual.City);
            Assert.Equal(fakeSettlementEntity.Street, actual.Street);
            Assert.Equal(fakeSettlementEntity.BuildingNo, actual.BuildingNo);
            Assert.Equal(fakeSettlementEntity.FlatNo, actual.FlatNo);

        }

    }
}