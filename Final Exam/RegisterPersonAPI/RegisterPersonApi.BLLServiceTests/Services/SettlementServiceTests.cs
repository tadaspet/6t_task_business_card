using Moq;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using Xunit;

namespace RegisterPersonApi.BLL.Services.Tests
{
    public class SettlementServiceTests
    {
        private readonly Mock<ISettlementRepository> _setRepo;
        private readonly SettlementService _sut;

        public SettlementServiceTests()
        {
            _setRepo = new Mock<ISettlementRepository>();
            _sut = new SettlementService(_setRepo.Object);
        }

        [Fact]
        public void WhenGetSettlement_ReceivesGuid_ReturnsSettlement()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var fakeSettlement = new Settlement
            {
                City = "TestCity",
                Street = "TestStreet",
                BuildingNo = "BuldingNo",
                FlatNo = "TestFlatNo",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14)
            };

            _setRepo.Setup(x => x.GetSettlement(userId)).Returns(fakeSettlement);

            // Act
            var result = _sut.GetSettlement(userId);

            // Assert
            Assert.Equal(fakeSettlement, result);
        }

        [Fact]
        public void WhenGetSettlement_ReceivesGuid_ReturnsNullSettlement()
        {
            // Arrange
            var userId = Guid.NewGuid();

            _setRepo.Setup(x => x.GetSettlement(userId)).Returns((Settlement)null);

            // Act
            var result = _sut.GetSettlement(userId);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void WhenAddNewSettlement_ReceivesSettlementAndGuid_ReturnsIntZeroValue()
        {
            // Arrange
            var expected = 0;
            var userId = Guid.NewGuid();
            var fakeSettlement = new Settlement
            {
                City = "TestCity",
                Street = "TestStreet",
                BuildingNo = "BuldingNo",
                FlatNo = "TestFlatNo",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14)
            };

            _setRepo.Setup(x => x.GetSettlement(userId)).Returns(fakeSettlement);

            //Act
            var result = _sut.AddNewSettlement(fakeSettlement, userId);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenAddNewSettlement_ReceivesSettlementAndGuid_ReturnsNotZeroValue()
        {
            // Arrange
            var expected = 1;
            var userId = Guid.NewGuid();
            var fakeSettlement = new Settlement
            {
                City = "TestCity",
                Street = "TestStreet",
                BuildingNo = "BuldingNo",
                FlatNo = "TestFlatNo",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14)
            };

            _setRepo.Setup(x => x.GetSettlement(userId)).Returns((Settlement)null);
            _setRepo.Setup(x => x.AddNewSettlement(fakeSettlement)).Returns(expected);

            //Act
            var result = _sut.AddNewSettlement(fakeSettlement, userId);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenUpdateSettlement_ReceivesSettlementAndGuid_ReturnsTrue()
        {
            // Arrange
            var expected = true;
            var userId = Guid.NewGuid();
            var fakeSettlement = new Settlement
            {
                City = "TestCity",
                Street = "TestStreet",
                BuildingNo = "BuldingNo",
                FlatNo = "TestFlatNo",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14)
            };

            _setRepo.Setup(x => x.GetSettlement(userId)).Returns(fakeSettlement);
            _setRepo.Setup(x => x.UpdateSettlement(fakeSettlement)).Returns(expected);
            //Act
            var result = _sut.UpdateSettlement(fakeSettlement, userId);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenUpdateSettlement_ReceivesSettlementAndGuid_ReturnsFalse()
        {
            // Arrange
            var expected = false;
            var userId = Guid.NewGuid();
            var fakeSettlement = new Settlement
            {
                City = "TestCity",
                Street = "TestStreet",
                BuildingNo = "BuldingNo",
                FlatNo = "TestFlatNo",
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                LastModified = new DateTime(2024, 2, 12, 16, 28, 14)
            };

            _setRepo.Setup(x => x.GetSettlement(userId)).Returns((Settlement)null);

            //Act
            var result = _sut.UpdateSettlement(fakeSettlement, userId);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}