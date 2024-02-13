using Microsoft.AspNetCore.Http;
using Moq;
using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonAPI.DTOs.Requests;
using System.Text;
using Xunit;

namespace RegisterPersonAPI.Mappers.Tests
{
    public class ImageFileMapperTests
    {
        private readonly Mock<IImageFileService> _imageService;
        private readonly ImageFileMapper _sut;

        public ImageFileMapperTests()
        {
            _imageService = new Mock<IImageFileService>();
            _sut = new ImageFileMapper(_imageService.Object);
        }

        [Fact]
        public void Map_WhenImageFileRequestDTO_ReturnImageFile()
        {
            // Arrange
            var stream = new MemoryStream(Encoding.UTF8.GetBytes("This is image file"));

            var formFile = new Mock<IFormFile>();
            formFile.Setup(f => f.FileName).Returns("imageName.png");
            formFile.Setup(f => f.Length).Returns(stream.Length);
            formFile.Setup(f => f.ContentType).Returns("*.png");
            formFile.Setup(f => f.CopyTo(It.IsAny<Stream>())).Callback<Stream>(s => stream.CopyTo(s));

            var dto = new ImageFileRequestDTO
            {
                Image = formFile.Object,
            };

            var personInfoId = 1;

            var resizedImage = new byte[] { 1, 2, 3 };

            _imageService.Setup(s => s.ResizeImage(It.IsAny<MemoryStream>())).Returns(resizedImage);

            // Act
            var imageFile = _sut.Map(dto, personInfoId);

            // Assert
            Assert.Equal(dto.Image.FileName, imageFile.FileName);
            Assert.Equal(dto.Image.ContentType, imageFile.ContentType);
            Assert.Equal(resizedImage.Length, imageFile.Size);
            Assert.Equal(resizedImage, imageFile.Content);
            Assert.Equal(personInfoId, imageFile.PersonInformationId);
        }
    }
}