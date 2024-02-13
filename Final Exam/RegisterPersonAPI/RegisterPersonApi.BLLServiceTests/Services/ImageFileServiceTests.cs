using Xunit;
using RegisterPersonApi.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using RegisterPersonApi.DAL.Entities;
using System.Drawing.Imaging;
using System.Drawing;

namespace RegisterPersonApi.BLL.Services.Tests
{
    public class ImageFileServiceTests
    {
        private readonly Mock<IImageFileRepository> _repo;
        private readonly ImageFileService _sut;

        public ImageFileServiceTests()
        {
            _repo = new Mock<IImageFileRepository>();
            _sut = new ImageFileService(_repo.Object);
        }
        [Fact]
        public void WhenGetImageFile_ReceivesGuid_ReturnsImageFile()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var fakeImageFile = new ImageFile
            {
                FileName = "TestName",
                ContentType = "TestContentType",
                Size = 1,
                Content = [1, 2, 3],
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                PersonInformationId = 1
            };

            _repo.Setup(x => x.GetImageFile(userId)).Returns(fakeImageFile);

            // Act
            var result = _sut.GetImageFile(userId);

            // Assert
            Assert.Equal(fakeImageFile, result);
        }

        [Fact]
        public void WhenGetImageFile_ReceivesGuid_ReturnsNullImageFile()
        {
            // Arrange
            var userId = Guid.NewGuid();

            _repo.Setup(x => x.GetImageFile(userId)).Returns((ImageFile)null);

            // Act
            var result = _sut.GetImageFile(userId);

            // Assert
            Assert.Null(result);
        }


        [Fact]
        public void WhenGetImageFile_ReceivesImageFileAndGuid_ReturnsImageFileIdIntegerValue()
        {
            // Arrange
            var expected = 2;
            var userId = Guid.NewGuid();
            var fakeNewImageFile = new ImageFile
            {
                Id = 2,
                FileName = "TestName",
                ContentType = "TestContentType",
                Size = 1,
                Content = [1, 2, 3],
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                PersonInformationId = 1
            };

            var fakeDbImageFile = new ImageFile
            {
                Id = 1,
                FileName = "TestDbName",
                ContentType = "TestDbContentType",
                Size = 1,
                Content = [1, 2, 3, 4],
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                PersonInformationId = 1
            };

            _repo.Setup(x => x.GetImageFile(userId)).Returns(fakeDbImageFile);
            _repo.Setup(x => x.AddImageFile(fakeNewImageFile)).Returns(expected);

            //Act
            var result = _sut.AddImageFile(fakeNewImageFile, userId);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenGetImageFile_ReceivesImageFileAndGuid_NoExistingImageFile_ReturnsImageFileIdIntegerValue()
        {
            // Arrange
            var expected = 3;
            var userId = Guid.NewGuid();
            var fakeNewImageFile = new ImageFile
            {
                Id = 3,
                FileName = "TestName",
                ContentType = "TestContentType",
                Size = 1,
                Content = [1, 2, 3],
                CreationDate = new DateTime(2024, 1, 12, 16, 28, 14),
                PersonInformationId = 1
            };

            _repo.Setup(x => x.GetImageFile(userId)).Returns((ImageFile)null);
            _repo.Setup(x => x.AddImageFile(fakeNewImageFile)).Returns(expected);

            //Act
            var result = _sut.AddImageFile(fakeNewImageFile, userId);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void WhenResizeImage_ReceivesImage500x500_ReturnsResizedImage200x200()
        {
            // Arrange
            var expectedSize = 200;
            var originalImage = new Bitmap(500, 500);
            using var memoryStream = new MemoryStream();
            originalImage.Save(memoryStream, ImageFormat.Png);
            memoryStream.Position = 0;

            // Act
            var resultBytes = _sut.ResizeImage(memoryStream);

            using var resultStream = new MemoryStream(resultBytes);
            using var resultImage = new Bitmap(resultStream);

            // Assert
            Assert.Equal(expectedSize, resultImage.Width);
            Assert.Equal(expectedSize, resultImage.Height);
        }

        [Fact]
        public void WhenResizeImage_ReceivesImage100x150_ReturnsResizedImage200x200()
        {
            // Arrange
            var expectedSize = 200;
            var originalImage = new Bitmap(100, 150);
            using var memoryStream = new MemoryStream();
            originalImage.Save(memoryStream, ImageFormat.Png);
            memoryStream.Position = 0;

            // Act
            var resultBytes = _sut.ResizeImage(memoryStream);

            using var resultStream = new MemoryStream(resultBytes);
            using var resultImage = new Bitmap(resultStream);

            // Assert
            Assert.Equal(expectedSize, resultImage.Width);
            Assert.Equal(expectedSize, resultImage.Height);
        }
    }
}